// See https://aka.ms/new-console-template for more information
// Circle Calculations-----------------------------------------------------
using System.ComponentModel;
using System.Reflection.Emit;



string circleRadiusOriginal = "";
bool inputOkay = false;

while (!inputOkay) 
{
    Console.WriteLine("Please enter the circle's radius: ");
    circleRadiusOriginal = Console.ReadLine();

    try
    {
        int.Parse(circleRadiusOriginal);
        inputOkay = true;
        CircleClass myCircle = new CircleClass();
        myCircle.Radius = int.Parse(circleRadiusOriginal);
        

    } 
    catch
    {

        Console.WriteLine("NaN");
        inputOkay = false;
    }

}




double circleRadius = double.Parse(circleRadiusOriginal);
double circleArea = Math.PI * Math.Pow(circleRadius, 2);
Console.WriteLine("Circle area: " + circleArea);

double circleCircumference = Math.PI * 2 * circleRadius;
Console.WriteLine("Circle circumference: " + circleCircumference);

double circleDiameter = 2 * circleRadius;
Console.WriteLine("Circle diameter: " + circleDiameter);


//Road Trip----------------------------------------------------------------
string milesPerGallonOriginal = "";
inputOkay = false;

while (!inputOkay)
{
    Console.WriteLine("Please enter the miles per gallon: ");
    milesPerGallonOriginal = Console.ReadLine();

    try
    {
        int.Parse(milesPerGallonOriginal);
        inputOkay = true;
    }
    catch
    {
        inputOkay = false;
    }

}

//}
double milesPerGallon = double.Parse(milesPerGallonOriginal);

double gasConsumed = milesPerGallon / circleCircumference;
Console.WriteLine("Gas consumed: " + gasConsumed);


//Bonus inside CircleClass.cs file