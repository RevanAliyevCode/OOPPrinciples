// See https://aka.ms/new-console-template for more information

using School;

Teacher teacher = new("Revan", "Eliyev");
Teacher teacher1 = new("Anar", "Eliyev");
Student student = new("Anar", "Mammedov");
Student student1 = new("Revan", "Mammedov");
Subject subject = new("C#", 120);
Subject subject1 = new("C++", 120);

Group studentGroup = new(12334);

studentGroup.AddStudent(student);
studentGroup.AddStudent(student1);
studentGroup.AddTeacher(teacher);
studentGroup.AddTeacher(teacher1);
studentGroup.AddSubject(subject);
studentGroup.AddSubject(subject1);

studentGroup.RemoveStudent(student);


studentGroup.GroupDetail();
