// See https://aka.ms/new-console-template for more information

using Assignment_1._1._4;

Console.WriteLine("Hello, World!");

Point P1 = new Point(1, 2);
Point P2 = new Point(3, 4);

string result = P1.CompareTwoPoints(P2);

Console.WriteLine($"""
                  Your first point ({P1.X}, {P1.Y})
                  Your second point ({P2.X}, {P2.Y})
                  {result}
                  """);