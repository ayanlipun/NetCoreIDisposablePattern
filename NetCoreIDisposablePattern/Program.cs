using System;

namespace NetCoreIDisposablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
            var serviceProxy = new ServiceProxy(null);
            serviceProxy.Get();
            serviceProxy.Post("");
        }
    }
}
