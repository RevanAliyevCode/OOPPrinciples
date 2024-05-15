using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Group
    {
        private Teacher[] teachers = [];
        private Student[] students = [];
        private Subject[] subjects = [];

        public int GroupNo { get; set; }
        public int Limit { get; set; } = 50;
        public Student[] Students { get => students; }
        public Teacher[] Teachers { get => teachers; }
        public Subject[] Subjects { get => subjects; }

        public Group(int groupNo)
        {
            GroupNo = groupNo;
        }

        public void AddStudent(Student student)
        {
            if (students.Length < Limit)
            {
                var arr = new Student[students.Length + 1];
                Array.Copy(students, arr, students.Length);

                arr[students.Length] = student;
                students = arr;
            }
            else
            {
                Console.WriteLine("This group is full");
            }
        }

        public void RemoveStudent(Student student)
        {
            int index = Array.IndexOf(Students, student);

            if (index != -1)
            {
                for (int i = index; i < Students.Length - 1; i++)
                {
                    Students[i] = Students[i + 1];
                }

                Array.Resize(ref students, Students.Length - 1);
            }
            else
            {
                Console.WriteLine("Bele bir sagird yoxdur");
            }
        }


        public void AddTeacher(Teacher teacher)
        {
            if ( Limit > teachers.Length)
            {
                Array.Resize(ref teachers, teachers.Length + 1);
                teachers[teachers.Length - 1] = teacher;
            }
            else Console.WriteLine("We do not have space");
        }

        public void RemoveTeacher(Teacher teacher)
        {
            int index = Array.IndexOf(Teachers, teacher);

            if (index != -1)
            {
                for (int i = index; i < Teachers.Length - 1; i++)
                {
                    Teachers[i] = Teachers[i + 1];
                }

                Array.Resize(ref teachers, Teachers.Length - 1);
            }
            else
            {
                Console.WriteLine("Bele bir muellim yoxdur");
            }
        }

        public void AddSubject(Subject subject)
        {
            if (Limit > subjects.Length)
            {
                Array.Resize(ref subjects, subjects.Length + 1);
                subjects[subjects.Length - 1] = subject;
            }
            else Console.WriteLine("We do not have space");
        }

        public void RemoveSubject(Subject subject)
        {
            int index = Array.IndexOf(Subjects, subject);

            if (index != -1)
            {
                for (int i = index; i < subjects.Length - 1; i++)
                {
                    subjects[i] = subjects[i + 1];
                }

                Array.Resize(ref subjects, subjects.Length - 1);
            }
            else
            {
                Console.WriteLine("Bele bir muellim yoxdur");
            }
        }

        public void GroupDetail()
        {
            Console.WriteLine($"Group No: {GroupNo}");
            Console.WriteLine($"\tTeachers:");
            foreach (Teacher teacher in Teachers)
            {
                Console.Write("\t\t");
                teacher.GetDetails();
            }

            Console.WriteLine($"\tStudents:");
            foreach (Student student in Students)
            {
                Console.Write("\t\t");
                student.GetDetails();
            }

            Console.WriteLine($"\tSubjects:");
            foreach (Subject subject in Subjects)
            {
                Console.Write("\t\t");
                subject.GetDetails();
            }
        }
    }
}
