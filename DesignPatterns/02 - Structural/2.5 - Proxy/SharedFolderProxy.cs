namespace DesignPatterns._02___Structural._2._5___Proxy
{
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;

        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }

        public void PerfomRWOperations()
        {
            if (employee.Role.ToString().ToUpper() == "CEO" || employee.Role.ToString().ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                System.Console.WriteLine("Shared folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerfomRWOperations();
            }
            else
            {
                System.Console.WriteLine("Share Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
