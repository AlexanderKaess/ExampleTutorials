using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows;

namespace Tutorial_13_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext myDataContext;

        public MainWindow()
        {
            InitializeComponent();

            //Verbindung zu der Datenbank "KaessDB" vorbereiten
            string connectionString = ConfigurationManager.ConnectionStrings["Tutorial_13_3.Properties.Settings.KaessDB1ConnectionString"].ConnectionString;
            //Auf Verbindung zur Datenbank "KaessDB" zugreifen
            myDataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniFromAlex();
            //UpdateAlex();
            DeleteMarco();
        }

        public void InsertUniversities()
        {
            myDataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            //In die Tabelle von University einfügen
            myDataContext.Universities.InsertOnSubmit(yale);

            University hsEsslingen = new University();
            hsEsslingen.Name = "HS Esslingen";
            //In die Tabelle von University einfügen
            myDataContext.Universities.InsertOnSubmit(hsEsslingen);

            //Änderung durchführen
            myDataContext.SubmitChanges();
            MainDataGrid.ItemsSource = myDataContext.Universities;
        }

        public void InsertStudents()
        {
            //Lampda expression - parameter => ausdruck
            //First - erstes Element worauf Lampda Expression passt
            University yale = myDataContext.Universities.First(uni => uni.Name.Equals("Yale"));
            University hsEsslingen = myDataContext.Universities.First(uni => uni.Name.Equals("HS Esslingen"));

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Alex", Gender = "male", UniversityId = hsEsslingen.Id });
            students.Add(new Student { Name = "Dani", Gender = "male", UniversityId = hsEsslingen.Id });
            students.Add(new Student { Name = "Marco", Gender = "male", UniversityId = yale.Id });
            students.Add(new Student { Name = "Larissa", Gender = "female", UniversityId = yale.Id });

            //In die Tabelle von Studenten einfügen
            myDataContext.Students.InsertAllOnSubmit(students);
            //Änderung durchführen
            myDataContext.SubmitChanges();
            MainDataGrid.ItemsSource = myDataContext.Students;
        }

        public void InsertLectures()
        {
            myDataContext.ExecuteCommand("delete from Lecture");

            List<Lecture> lectures = new List<Lecture>();
            lectures.Add(new Lecture { Id = 1, Name = "Mathe" });
            lectures.Add(new Lecture { Id = 2, Name = "Geschichte" });

            // In die Tabelle von Lectures einfügen
            myDataContext.Lectures.InsertAllOnSubmit(lectures);
            //Änderung durchführen
            myDataContext.SubmitChanges();
            MainDataGrid.ItemsSource = myDataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            //Lampda expression - parameter => ausdruck
            //First - erstes Element worauf Lampda Expression passt
            Student alex = myDataContext.Students.First(st => st.Name.Equals("Alex"));
            Student dani = myDataContext.Students.First(st => st.Name.Equals("Dani"));
            Student marco = myDataContext.Students.First(st => st.Name.Equals("Marco"));
            Student larissa = myDataContext.Students.First(st => st.Name.Equals("Larissa"));

            Lecture mathe = myDataContext.Lectures.First(lc => lc.Name.Equals("Mathe"));
            Lecture geschichte = myDataContext.Lectures.First(lc => lc.Name.Equals("Geschichte"));

            StudentLecture slAlex = new StudentLecture();
            slAlex.StudentId = alex.Id;
            slAlex.LectureId = mathe.Id;
            myDataContext.StudentLectures.InsertOnSubmit(slAlex);

            myDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = alex, Lecture = geschichte });
            myDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = dani, Lecture = mathe });
            myDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = marco, Lecture = geschichte });
            myDataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = larissa, Lecture = geschichte });

            //Änderung durchführen
            myDataContext.SubmitChanges();
            MainDataGrid.ItemsSource = myDataContext.StudentLectures;
        }

        public void GetUniFromAlex()
        {
            Student alex = myDataContext.Students.First(st => st.Name.Equals("Alex"));
            University alexUni = alex.University;

            List<University> universities = new List<University>();
            universities.Add(alexUni);

            //ItemSource will eine IEnumerable
            MainDataGrid.ItemsSource = universities;
        }

        public void UpdateAlex()
        {
            Student alex = myDataContext.Students.FirstOrDefault(st => st.Name.Equals("Alex"));
            alex.Name = "Alexander";
            myDataContext.SubmitChanges();
            MainDataGrid.ItemsSource = myDataContext.Students;
        }

        public void DeleteMarco()
        {
            Student marco = myDataContext.Students.FirstOrDefault(st => st.Name.Equals("Marco"));
            myDataContext.Students.DeleteOnSubmit(marco);
            myDataContext.SubmitChanges();
            MainDataGrid.ItemsSource = myDataContext.Students;

        }

    }
}
