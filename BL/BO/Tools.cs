using BlApi;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System;
using System.Reflection;

namespace BO;

public static class Tools
{
    public static string ToStringProperty<T>(this T obj, string prefix = "")
    {
        StringBuilder sb = new StringBuilder();
        Type type = obj.GetType();
        foreach (PropertyInfo prop in type.GetProperties())
        {
            if (prop.PropertyType.IsPrimitive || prop.PropertyType == typeof(string)
                || prop.PropertyType == typeof(DateOnly))
                sb.AppendLine($"{prefix}{prop.Name}= {prop.GetValue(obj)}");
            else
                sb.Append($"{prefix}{prop.Name}=\n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
        }
        return sb.ToString();
    }

    //public static T Convert<S, T>(this S obj) where T : new()
    //{
    //    if (typeof(S).Name != typeof(T).Name)
    //        throw new Exception("classes dont match");
    //    T t = new T();
    //    Type type = obj.GetType();
    //    foreach (PropertyInfo prop in type.GetProperties())
    //    {
    //        PropertyInfo p = typeof(T).GetProperty(prop.Name);
    //        if (Nullable.GetUnderlyingType(p.PropertyType) != null)
    //        {
    //            var underlyingType = Nullable.GetUnderlyingType(p.PropertyType);
    //            var convertedValue = System.Convert.ChangeType(prop.GetValue(obj), underlyingType); // Fixed by explicitly referencing System.Convert
    //            p.SetValue(t, convertedValue);
    //        }
    //        else
    //        {
    //            p.SetValue(t, prop.GetValue(obj));
    //        }
    //    }
    //    return t;
    //}
    public static T Convert<S, T>(this S source) where T : new()
    {
        if (typeof(S).Name != typeof(T).Name)
            throw new Exception($"Class names do not match: {typeof(S).Name} != {typeof(T).Name}");

        T target = new T();

        var sourceProperties = typeof(S).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var targetProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var sourceProp in sourceProperties)
        {
            var targetProp = targetProperties.FirstOrDefault(p => p.Name == sourceProp.Name && p.CanWrite);
            if (targetProp == null) continue;

            object sourceValue = sourceProp.GetValue(source);
            if (sourceValue == null)
            {
                targetProp.SetValue(target, null);
                continue;
            }

            Type sourceType = sourceProp.PropertyType;
            Type targetType = targetProp.PropertyType;

            try
            {
                // טיפוסי Enum רגילים
                if (IsEnum(sourceType) && IsEnum(targetType))
                {
                    string name = Enum.GetName(UnwrapNullable(sourceType), sourceValue);
                    object targetEnum = Enum.Parse(UnwrapNullable(targetType), name);
                    targetProp.SetValue(target, targetEnum);
                }
                // Nullable מסוג Enum
                else if (IsEnum(sourceType) && !IsEnum(targetType))
                {
                    throw new Exception($"Cannot assign enum to non-enum target: {targetType.Name}");
                }
                // Nullable רגיל
                else if (Nullable.GetUnderlyingType(targetType) != null)
                {
                    var underlying = Nullable.GetUnderlyingType(targetType);
                    var converted = System.Convert.ChangeType(sourceValue, underlying);
                    targetProp.SetValue(target, converted);
                }
                // טיפוסים תואמים או ניתנים להמרה
                else if (targetType.IsAssignableFrom(sourceType))
                {
                    targetProp.SetValue(target, sourceValue);
                }
                else
                {
                    var converted = System.Convert.ChangeType(sourceValue, targetType);
                    targetProp.SetValue(target, converted);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error converting property '{sourceProp.Name}': {ex.Message}", ex);
            }
        }

        return target;
    }

    private static bool IsEnum(Type type)
    {
        return UnwrapNullable(type).IsEnum;
    }

    private static Type UnwrapNullable(Type type)
    {
        return Nullable.GetUnderlyingType(type) ?? type;
    }


}



