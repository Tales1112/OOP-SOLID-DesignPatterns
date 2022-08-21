namespace DesignPatterns._02___Structural._2._5___Proxy
{
    public class Employee
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public Employee(string userName, string password, Role role)
        {
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
