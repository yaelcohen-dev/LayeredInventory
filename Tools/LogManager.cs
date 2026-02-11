
namespace Tools;

public static class LogManager
{
    private const string Log = @"Log";
    private static string tab = "\t";
    public static string PathDir()
    {
        string path = Log + "/" + DateTime.Now.Year + '-' + DateTime.Now.Month;
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        return path;
    }
    public static string PathFile()
    {
        string path = PathDir() + "/" + DateTime.Now.Day + ".txt";
        if (!File.Exists(path))
            File.Create(path).Close();
        return path;
    }
    public static void WriteInStart(string project, string function, string message)
    {
        tab += "\t";
        WriteLoLog(project, function, message);
    }
    public static void WriteInEnd(string project, string function, string message)
    {
        WriteLoLog(project, function, message);
        tab = tab.Substring(1);
    }
    public static void WriteLoLog(string project, string function, string message)
    {
        using (StreamWriter sw = new StreamWriter(PathFile(), true))
        {
            sw.WriteLine($"{DateTime.Now}{tab}{project}.{function}:\t{message}");
        }
    }
    public static void CleanDirs()
    {
        string[] arr = Directory.GetDirectories(Log);
        for (int i = 0; i < arr.Length; i++)
        {
            if (ShouldCleaned(int.Parse(arr[i].Substring(4, 4)), int.Parse(arr[i].Substring(9))))
                Directory.Delete(arr[i], true);
        }
    }
    private static bool ShouldCleaned(int year, int month)
    {
        if (year == DateTime.Now.Year && month >= DateTime.Now.Month - 1)
            return false;
        if (year == DateTime.Now.Year -1 && (month==12&&DateTime.Now.Month==1))
            return false;
        return true;
    }
}
