using static DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_2.Students.Students;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_2.Factories
{
    public class UIStudentFactory : StudentFactory
    {
        public override IStudent GetStudent(string studentDept)
        {
            if (studentDept.Equals("Med"))
                return new MedStudentUI();
            else if (studentDept.Equals("Mech"))
                return new MechStudentUI();
            else
                return null;
        }
    }

    public class FutaStudentFactory : StudentFactory
    {
        public override IStudent GetStudent(string studentDept)
        {
            if (studentDept.Equals("Geo"))
                return new GeoStudentFuta();
            else if (studentDept.Equals("Bio"))
                return new BioStudentFuta();
            else if (studentDept.Equals("Chem"))
                return new ChemStudentFuta();
            else
                return null;
        }
    }
}
