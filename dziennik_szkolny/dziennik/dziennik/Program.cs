namespace dziennik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolSystem schoolSystem = new SchoolSystem();

            // Dodajmy kilku uczniów, nauczycieli, przedmiotów i ocen do systemu
            //schoolSystem.AddStudent(new Student(1, "John Doe", 10));
            //schoolSystem.AddStudent(new Student(2, "Jane Smith", 11));
            //schoolSystem.AddTeacher(new Teacher(1, "Mr. Johnson", "Math"));
            //schoolSystem.AddTeacher(new Teacher(2, "Ms. Adams", "English"));
            //schoolSystem.AddSubject(new Mathematics() { Id = 1, Name = "Mathematics", Level = 1 });
            //schoolSystem.AddSubject(new Physics() { Id = 2, Name = "Physics", Field = "Mechanics" });
            //schoolSystem.AddGrade(new Grade() { Id = 1, StudentId = 1, SubjectId = 1, Value = 4.5 });
            //schoolSystem.AddGrade(new Grade() { Id = 2, StudentId = 2, SubjectId = 2, Value = 3.75 });

            // Zapisz dane do pliku
            //schoolSystem.SaveData("school_data.txt");
            //Console.WriteLine("Data saved to file.");

            // Wyświetlmy listę uczniów, nauczycieli, przedmiotów i ocen
            schoolSystem = new SchoolSystem();
            schoolSystem.LoadData("school_data.txt");
            schoolSystem.DisplayStudents();
            Console.WriteLine();
            schoolSystem.DisplayTeachers();
            Console.WriteLine();
            schoolSystem.DisplaySubjects();
            Console.WriteLine();
            schoolSystem.DisplayGrades();

        }
    }
}