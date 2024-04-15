// C# LINQ
// Task 1
int[] numbers = { 1, 2, 3, 4, 5 ,6,7,8,9,10};
var evenNumbers = numbers.Where(i => i % 2 == 0);
foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("------------------------------------");

// Task 2
double[] grades = { 90.1, 80.6, 65.9, 70.8, 88.8 };
var avrageGrades = grades.Average();



Console.Write($"The average grades: {avrageGrades}");

Console.WriteLine("\n------------------------------------");


//Bonus
var studentGrages = grades.OrderBy(x => x);

foreach (int grade in studentGrages)
{
    Console.WriteLine(grade);
}

Console.WriteLine("------------------------------------");

// C# Functions
// Task 1 

void Greet(string name)
{
    Console.WriteLine($"Hello {name}");
}
Greet("Mubarak");

Console.WriteLine($"First function (original)  {TwoMethods.calculateVolume(7.0, 60.9, 80.9)}");
Console.WriteLine($"Second function  {TwoMethods.calculateVolume(7.0, 60.9, 80.9, 4.0)}");


Console.WriteLine("------------------------------------");

// Task 2 
class TwoMethods
{
    public static double calculateVolume(double length, double width, double height)
    {
        return width * height * length;
    }

    public static double calculateVolume(double length, double width, double height, double somethingNew)
    {
        return length * width * height * somethingNew;
    }

}