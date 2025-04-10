// See https://aka.ms/new-console-template for more information

using Assignment_1._1._4;

Student student = new();

Point P1 = new Point(1, 2);
Point P2 = new Point(3, 4);

string result = P1.CompareTwoPoints(P2);

Console.WriteLine($"""
                  Comparing Points:
                  =================
                  
                  Your first point ({P1.X}, {P1.Y})
                  Your second point ({P2.X}, {P2.Y})
                  {result}
                  
                  """);

student.StudentId = 8675309;
student.StudentFName = "John";
student.StudentLName = "Doe";
student.StudentGrade = 'A';

Console.WriteLine($"""
                  Student Information:
                  =====================
                  
                  Student ID: {student.StudentId}
                  Student First Name: {student.StudentFName}
                  Student Last Name: {student.StudentLName}
                  Student Grade: {student.StudentGrade}
                  """);