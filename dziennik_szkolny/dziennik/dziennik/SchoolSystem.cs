using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziennik
{
    class SchoolSystem
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Subject> subjects;
        private List<Grade> grades;
        private DataManager dataManager;

        public SchoolSystem()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            subjects = new List<Subject>();
            grades = new List<Grade>();
            dataManager = new DataManager();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void AddGrade(Grade grade)
        {
            grades.Add(grade);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void RemoveSubject(Subject subject)
        {
            subjects.Remove(subject);
        }

        public void RemoveGrade(Grade grade)
        {
            grades.Remove(grade);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
            }
        }

        public void DisplayTeachers()
        {
            Console.WriteLine("Teachers:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.Id}, Name: {teacher.Name}, Subject: {teacher.Subject}");
            }
        }

        public void DisplaySubjects()
        {
            Console.WriteLine("Subjects:");
            foreach (var subject in subjects)
            {
                Console.WriteLine($"ID: {subject.Id}, Name: {subject.Name}");
            }
        }

        public void DisplayGrades()
        {
            Console.WriteLine("Grades:");
            foreach (var grade in grades)
            {
                Console.WriteLine($"ID: {grade.Id}, StudentID: {grade.StudentId}, SubjectID: {grade.SubjectId}, Value: {grade.Value}");
            }
        }
        public void SaveData(string fileName)
        {
            string data = "";

            // Tworzenie danych do zapisania w formacie tekstowym
            foreach (var student in students)
            {
                data += $"Student,{student.Id},{student.Name},{student.Grade}\n";
            }

            foreach (var teacher in teachers)
            {
                data += $"Teacher,{teacher.Id},{teacher.Name},{teacher.Subject}\n";
            }

            foreach (var subject in subjects)
            {
                data += $"Subject,{subject.Id},{subject.Name}\n";
            }

            foreach (var grade in grades)
            {
                data += $"Grade,{grade.Id},{grade.StudentId},{grade.SubjectId},{grade.Value}\n";
            }

            // Zapis danych do pliku
            dataManager.SaveToFile(fileName, data);
        }

        // Metoda do odczytu danych z pliku tekstowego
        public void LoadData(string fileName)
        {
            string[] lines = dataManager.ReadFromFile(fileName).Split('\n');

            foreach (var line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 2)
                {
                    string type = parts[0];
                    int id = int.Parse(parts[1]);

                    switch (type)
                    {
                        case "Student":
                            students.Add(new Student(id, parts[2], int.Parse(parts[3])));
                            break;
                        case "Teacher":
                            teachers.Add(new Teacher(id, parts[2], parts[3]));
                            break;
                        case "Subject":
                            subjects.Add(new Subject() { Id = id, Name = parts[2] });
                            break;
                        case "Grade":
                            grades.Add(new Grade() { Id = id, StudentId = int.Parse(parts[2]), SubjectId = int.Parse(parts[3]), Value = double.Parse(parts[4]) });
                            break;
                        default:
                            Console.WriteLine("Unknown data type.");
                            break;
                    }
                }
            }
        }
    }
}
