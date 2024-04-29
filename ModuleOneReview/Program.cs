namespace ModuleOneReview;

class Program
{
    static void Main(string[] args)
    {
        CircleArea();  //call a method

    }

    public static void CircleArea()  // define attribute, return, and name of method
    {
        Console.WriteLine("To calculate the area of a circle we need two things, the value if Pi and the radius of the circle.\n Pi is equal to 3.14 here. What is the radius?");

        double radius1 = double.Parse(Console.ReadLine());      //input radius value, convert to double

        double pi = 3.14;                                       // initialize and declare pi

        double cirArea = pi * radius1 * radius1;                // calculate with varriables

        Console.WriteLine($"A circle with a radius of {radius1} has an area of {cirArea}");             // result


    }
}

