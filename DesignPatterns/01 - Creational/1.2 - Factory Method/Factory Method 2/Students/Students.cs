using System.Collections.Generic;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_2.Students
{
    // Concrete Products
    public class Students
    {
        public class BioStudentFuta : IStudent
        {
            public List<string> Courses()
            {
                return new List<string> { "Bio 101", "Bio 201" };
            }
        }
        public class ChemStudentFuta : IStudent
        {
            public List<string> Courses()
            {
                return new List<string> { "Chem 101", "Chem 201" };
            }
        }

        public class GeoStudentFuta : IStudent
        {
            public List<string> Courses()
            {
                return new List<string> { "Geo 101", "Chem 201" };
            }
        }
        public class MedStudentUI : IStudent
        {
            public List<string> Courses()
            {
                return new List<string> { "SRG 101", "SRG 102" };
            }
        }

        public class MechStudentUI : IStudent
        {
            public List<string> Courses()
            {
                return new List<string> { "MEE 101", "MEE 102" };
            }
        }
    }
}
