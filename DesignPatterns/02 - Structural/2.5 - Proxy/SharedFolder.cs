namespace DesignPatterns._02___Structural._2._5___Proxy
{
    public class SharedFolder : ISharedFolder
    {
        public void PerfomRWOperations()
        {
            System.Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
