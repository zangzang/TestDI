namespace TestDI.Core
{
    // IService.cs
    public interface IService
    {
        string GetData();
    }

    // ServiceA.cs
    public class ServiceA : IService
    {
        public string GetData() => "Data from ServiceA";
    }

    // ServiceB.cs
    public class ServiceB : IService
    {
        public string GetData() => "Data from ServiceB";
    }

}
