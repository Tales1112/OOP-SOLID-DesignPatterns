using System;

namespace DesignPatterns._01___Creational._1._5___Prototype
{
    public class Person : IPrototype  
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person(int age, DateTime birthDate, string name, IdInfo idInfo)
        {
            Age = age;
            BirthDate = birthDate;
            Name = name;
            IdInfo = idInfo;
        }

        public void Debug()
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                   this.Name, this.Age, this.BirthDate);
            Console.WriteLine("      ID#: {0:d}", this.IdInfo.IdNumber);
        }

        public IPrototype DeepCopy()
        {
            Person clonedPerson = (Person)this.MemberwiseClone();
            clonedPerson.IdInfo = new IdInfo(this.IdInfo.IdNumber);

            return clonedPerson;
        }

        public IPrototype ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }
    }
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int id)
        {
            this.IdNumber = id;
        }
    }
}
