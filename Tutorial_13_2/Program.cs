using System;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Tutorial_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>20</Age>
                        <University>Hs Esslingen</University>
                        <Semester>2</Semester>
                    </Student>
                    <Student>
                        <Name>Dani</Name>
                        <Age>22</Age>
                        <University>Hs Esslingen</University>
                        <Semester>1</Semester>
                    </Student>
                    <Student>
                        <Name>Marco</Name>
                        <Age>24</Age>
                        <University>Yale</University>
                        <Semester>5</Semester>
                    </Student>
                    <Student>
                        <Name>Franz</Name>
                        <Age>28</Age>
                        <University>Yale</University>
                        <Semester>21</Semester>
                    </Student>
                </Students>";

            //Erstellen von Object "studentsXmlDoc" vom Typ "XDocument"
            XDocument studentsXmlDoc = new XDocument();
            studentsXmlDoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXmlDoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach (var st in students)
            {
                Console.WriteLine("Student {0} mit Alter {1} auf der Uni {2} im Semester {3}", st.Name, st.Age, st.University, st.Semester);
            }

            Console.WriteLine("\n\n");
            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var st in sortedStudents)
            {
                Console.WriteLine("Student {0} mit Alter {1} auf der Uni {2} im Semester {3}", st.Name, st.Age, st.University, st.Semester);
            }

            Console.ReadKey();
        }
    }
}
