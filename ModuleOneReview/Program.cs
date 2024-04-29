namespace ModuleOneReview;

class Program
{
    static void Main(string[] args)
    {
        CircleArea();  //call a method
        TriangleArea();     // call Triangle method
       
        
    }

    public static void CircleArea()  // define attribute, return, and name of method
    {
        Console.WriteLine("To calculate the area of a circle we need two things, the value if Pi and the radius of the circle.\n Pi is equal to 3.14 here. What is the radius in cm?");

        double radius1 = double.Parse(Console.ReadLine());      //input radius value, convert to double

        double pi = 3.14;                                       // initialize and declare pi

        double cirArea = pi * radius1 * radius1;                // calculate with varriables

        Console.WriteLine($"A circle with a radius of {radius1} has an area of {cirArea}sq/cm.");             // result


    }

    public static void TriangleArea()   //  define attribute, return, and name of method (Area of Triangle = (Base X Height) / 2)
    {
        Console.WriteLine("To calculate the area of a triangle we need two things, the length of the base and the height of the triangle.\nWhat is the base in cm?");

        double base1 = double.Parse(Console.ReadLine());                                         //input base value, convert to double

        Console.WriteLine("Now enter the value of the triangle's height in cm.");

        double height1 = double.Parse(Console.ReadLine());                                       // initialize and declare height, get input

        double triArea = (base1 * height1) / 2;                // calculate with varriables

        Console.WriteLine($"A Triangle with a base of {base1} and a height of {height1} has an area of {triArea}sq/cm.");             // result
    }

 
}

