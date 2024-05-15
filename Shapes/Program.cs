// See https://aka.ms/new-console-template for more information
using Shapes;

Circle circle = new(14);
Square square = new(12);
Triangle triangle = new(5, 6);

circle.CalculateArea();
square.CalculateArea();
triangle.CalculateArea();

Console.WriteLine($"Circle area: {circle.Area}, Square area: {square.Area}, Triangle area: {triangle.Area}");