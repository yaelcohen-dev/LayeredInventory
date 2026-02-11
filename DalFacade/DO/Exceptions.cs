
namespace DO;
[Serializable]
public class DalExceptionEntityExists : Exception
{
	public DalExceptionEntityExists(string message):base(message)
	{ }
}
[Serializable]
public class DalExceptionEntityDoesNotExist : Exception
{
    public DalExceptionEntityDoesNotExist(string message) : base(message)
    { }
}