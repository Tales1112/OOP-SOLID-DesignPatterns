using System;

namespace DesignPatterns._02___Structural._2._5___Proxy
{
    public class ExeceucaoProxy
    {
        public static void Executar()
        {
            Console.WriteLine("Client passing employee with Role Developer to folderproxy");
            Employee emp1 = new Employee("Tales", "Tales123", Role.Developer);
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);
            folderProxy1.PerfomRWOperations();

            Console.WriteLine();


            Console.WriteLine("Client passing employee with Role Manager to folderproxy");
            Employee emp2 = new Employee("Helton", "Helton123", Role.Manager);
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);
            folderProxy2.PerfomRWOperations();
            Console.Read();

        }
    }
}
