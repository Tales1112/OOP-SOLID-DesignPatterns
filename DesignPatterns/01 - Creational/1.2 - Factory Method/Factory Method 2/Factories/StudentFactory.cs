namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_2.Factories
{
    //Creator
    public abstract class StudentFactory
    {
        public abstract IStudent GetStudent(string studentDept);

        public static StudentFactory CreateStudentFactory(string studentSch)
        {
            if (studentSch.Equals("UI"))
                return new UIStudentFactory();
            else
                return new FutaStudentFactory();
        }
    }
}
