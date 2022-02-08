using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, Kaess is the best!");

            //Linq mit Array
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Oddnumbers(numbers);


            //Linq mit Listen
            UniversityManager uniMan = new UniversityManager();
            uniMan.MaleStudents();
            uniMan.FemaleStudents();
            uniMan.SortedStudentsByAge();
            uniMan.ShowStuntsFromEsslingen();

            Console.WriteLine("\n\n");
            int[] someInts = { 30, 22, 33, 1, 4, 7 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            foreach (int mySi in sortedInts)
            {
                Console.WriteLine("Zahl: " + mySi);
            }

            Console.WriteLine("\n");
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            foreach (int myRi in reversedInts)
            {
                Console.WriteLine("Zahl: " + myRi);
            }

            Console.WriteLine("\n");
            IEnumerable<int> reverseSortedInts = from i in someInts orderby i descending select i;
            foreach (int myReSi in reverseSortedInts)
            {
                Console.WriteLine("Zahl: " + myReSi);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Bitte geben Sie die ID der Universität an die ausgwählt werden soll");
            Console.WriteLine("Yale ist hat ID 1");
            Console.WriteLine("HS Esslingen hat ID 2");
            Console.WriteLine("UserInput: ");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = Convert.ToInt32(userInput);
                uniMan.ShowAllStudentesFromThatUniversity(userInputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Falscher Wert, bitte eine Zahl eingeben");
            }

            uniMan.StudentAndUniversityNameCollection();

            Console.ReadKey();
        }

        //Linq mit Array
        static void Oddnumbers(int[] numbers)
        {
            Console.WriteLine("Ungerade Zahle: ");

            //enumeration = Aufzählung
            //IEnumerable ist ein aufzählbares Element
            //Inferface das sagt "ich bin aufzählbar"
            //IEnumerable vom Typ int
            //oddnumbers beinhaltet die ungeraden Zahlen
            IEnumerable<int> oddnumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine("OddNumbers ist vom Typ: {0}", oddnumbers);

            foreach (int oddnumber in oddnumbers)
            {
                Console.WriteLine("Number: {0}", oddnumber);
            }
        }

        //Linq mit Listen
        class UniversityManager
        {
            //Deklarieren der Listen
            public List<University> universities;
            public List<Student> students;

            //Konstruktor
            public UniversityManager()
            {
                //Initialisieren der Listen
                universities = new List<University>();
                students = new List<Student>();

                //Befüllen der University-Liste
                universities.Add(new University { Id = 1, Name = "Yale" });
                universities.Add(new University { Id = 2, Name = "HS Esslingen" });

                //Befüllen der Student-Liste
                students.Add(new Student { Id = 1, Name = "Hans", Age = 51, Gender = "male", UniversityId = 1 });
                students.Add(new Student { Id = 2, Name = "Alex", Age = 30, Gender = "male", UniversityId = 2 });
                students.Add(new Student { Id = 3, Name = "Dani", Age = 29, Gender = "male", UniversityId = 2 });
                students.Add(new Student { Id = 4, Name = "Marco", Age = 30, Gender = "male", UniversityId = 1 });
                students.Add(new Student { Id = 5, Name = "Larry", Age = 28, Gender = "female", UniversityId = 1 });     
            }

            public void MaleStudents()
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Männliche Studenten: ");
                IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;

                Console.WriteLine("Student ist vom Typ: {0}", maleStudents);

                foreach (Student st in maleStudents)
                {
                    st.PrintInfomation();
                }
            }

            public void FemaleStudents()
            {

                IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;

                Console.WriteLine("Student ist vom Typ: {0}", femaleStudents);

                foreach (Student st in femaleStudents)
                {
                    st.PrintInfomation();
                }
            }

            public void SortedStudentsByAge()
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Studenten sortiert nach Alter: ");
                var sortedStudents = from student in students orderby student.Age select student;

                foreach (Student st in sortedStudents)
                {
                    st.PrintInfomation();
                }
            }

            public void ShowStuntsFromEsslingen()
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Alle Studenten von Esslingen: ");
                IEnumerable<Student> stundentsEsslingen = from student in students
                                                          join university in universities on student.UniversityId
                                                          equals university.Id
                                                          where university.Name == "HS Esslingen"
                                                          select student;
                
                foreach (Student st in stundentsEsslingen)
                {
                    st.PrintInfomation();
                }
            }

            public void ShowAllStudentesFromThatUniversity(int uniID)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Alle Studenten von ausgewählter Universität: ");
                IEnumerable<Student> studentsFromUni = from student in students
                                                       join university in universities on student.UniversityId
                                                       equals university.Id
                                                       where university.Id == uniID
                                                       select student;

                foreach (Student st in studentsFromUni)
                {
                    st.PrintInfomation();
                }
            }

            public void StudentAndUniversityNameCollection()
            {
                var myCollection = from student in students
                                   join university in universities on student.UniversityId
                                   equals university.Id
                                   orderby student.Name
                                   select new { StudentName = student.Name, UniversityName = university.Name };
                Console.WriteLine("Neue Sammlung: ");
                foreach (var col in myCollection)
                {
                    Console.WriteLine("Student {0} von der University {1}", col.StudentName, col.UniversityName);

                }
            }
        }

         class University
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void PrintInfomation()
            {
                Console.WriteLine("Universität mit Name: {0} und ID: {1}", Name, Id);
            }
        }

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }

            //Fremdschlüssel - foreign Key - Verknüpfung von Student zu University
            public int UniversityId { get; set; }

            public void PrintInfomation()
            {
                Console.WriteLine("Student mit Name: {0} und ID: {1} und Geschlecht: {2} und Alter: {3} " +
                    "von der UniversitätID: {4}", Name, Id, Gender, Age, UniversityId);
            }
        }
    }
}
