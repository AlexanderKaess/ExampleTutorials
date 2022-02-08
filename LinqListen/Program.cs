using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LinqListen
{
    //list of Standardabfrageoperatoren https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Alex!");
            Console.WriteLine("");

            //build object UniversityManager
            UniversityManager um = new UniversityManager();

            //call methode of UniversityManager
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            um.StudentAndUniversityNameCollection();
            //um.AllStudentsFromThatUniversity();

            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            foreach (int number in sortedInts)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");

            IEnumerable<int> reversedInts = sortedInts.Reverse();
            foreach (int revNumber in reversedInts)
            {
                Console.WriteLine(revNumber);
            }
            Console.WriteLine("");

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            foreach (int revSorNumber in reversedSortedInts)
            {
                Console.WriteLine(revSorNumber);
            }
            Console.WriteLine("");


            Console.ReadKey();
        }

        class UniversityManager
        {
            //list of universities of typ University
            public List<University> universities;
            //list of students of typ Student
            public List<Student> students;

            //contructor
            public UniversityManager()
            {
                //initialize
                universities = new List<University>();
                students = new List<Student>();

                //fill the list of unversities
                universities.Add(new University { Id = 1, Name = "Yale" });
                universities.Add(new University { Id = 2, Name = "Beijing Tech" });

                // fil the list of students
                students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
                students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
                students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
                students.Add(new Student { Id = 4, Name = "Alex", Gender = "male", Age = 20, UniversityId = 2 });
                students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
                students.Add(new Student { Id = 6, Name = "Karl", Gender = "male", Age = 25, UniversityId = 1 });
            }

            //methode to show all male students
            public void MaleStudents()
            {
                IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
                Console.WriteLine("Male Students: ");

                foreach (var student in maleStudents)
                {
                    student.Print();
                }
                Console.WriteLine("");
            }

            //methode to show all female students
            public void FemaleStudents()
            {
                IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
                Console.WriteLine("Female Students: ");

                foreach (var student in femaleStudents)
                {
                    student.Print();
                }
                Console.WriteLine("");
            }

            //methode to sort students by their age
            public void SortStudentsByAge()
            {
                //var recognizes automatically the typ of sortedStudents, performance is getting worse a little bit
                //sort by (orderby) age and return the student to sortedStudents
                var sortedStudents = from student in students orderby student.Age select student;

                Console.WriteLine("Sorted students by age: ");
                foreach (Student student in sortedStudents)
                {
                    student.Print();
                }
                Console.WriteLine("");
            }

            //methode to sort students by their university
            public void AllStudentsFromBeijingTech()
            {
                //student will go through the list Students
                //join (connect), connect the students and the university depending on the student.UniversityId
                //equals (conforms), student.UniversityId conforms university.Id with university.Name is Beijing Tech
                IEnumerable<Student> bjtStudents = from student in students
                                                   join university in universities on student.UniversityId 
                                                   equals university.Id where university.Name == "Beijing Tech"
                                                   select student;

                Console.WriteLine("Sorted students by Beijing Tech University: ");
                foreach (Student student in bjtStudents)
                {
                    student.Print();
                }
                Console.WriteLine("");
            }

            //methode to sort students by their university, universityId is a user input
            public void AllStudentsFromThatUniversity()
            {
                Console.WriteLine("Please, select a University");
                Console.WriteLine("1 for Yale");
                Console.WriteLine("2 for Beijing Tech");

                //input from user
                string input = Console.ReadLine();
                try
                {
                    int inputAsInt = Convert.ToInt32(input);
                    Console.WriteLine("You entered: " + input);

                    IEnumerable<Student> selectedUniversityStudents = from student in students
                                                                      join university in universities on student.UniversityId
                                                                      equals university.Id
                                                                      where university.Id == inputAsInt
                                                                      select student;

                    Console.WriteLine("Following students are in University");
                    foreach (Student student in selectedUniversityStudents)
                    {
                        student.Print();
                    }
                    Console.WriteLine("");
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong value entered"); ;
                }
            }

            //methode to show just the student name and university where the student is
            public void StudentAndUniversityNameCollection()
            {
                var newCollection = from student in students
                                    join university in universities on student.UniversityId
                                    equals university.Id
                                    orderby student.Name
                                    select new { StudentName = student.Name, UniversityName = university.Name };

                Console.WriteLine("New Collection");
                foreach (var col in newCollection)
                {
                    Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
                }
                Console.WriteLine("");
            }

        }

        class University
        {
            //properties
            public int Id { get; set; }
            public string Name { get; set; }

            //method to show Id and Name
            public void Print()
            {
                Console.WriteLine("University {0} with the Id {1}", Name, Id);
            }
        }

        class Student
        {
            //properties
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }

            //foreign key (Fremdschlüssel)
            //assignment of a student to a university 
            public int UniversityId { get; set; }

            //method to show informations about a student
            public void Print()
            {
                Console.WriteLine("Student {0} with Id {1}, the Gender {2} and Age {3} of the University {4}", Name, Id, Gender, Age, UniversityId);
            }
        }

    }
}
