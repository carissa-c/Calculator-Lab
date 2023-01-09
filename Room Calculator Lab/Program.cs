
Console.WriteLine("What is the length of the classroom in ft?");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("What is the width of the classroom in ft?");
double width = double.Parse(Console.ReadLine());

Console.WriteLine("What is the height of the classroom?");
double height = double.Parse(Console.ReadLine());

double area = (length * width);

Console.WriteLine("Perimeter of the classroom is " + length + "x" + width);

Console.WriteLine("Area of the classroom is " + area + " sq ft");
// Console.WriteLine("Area of the classroom is " + (length * width) + " sq ft");

//Application bullet 3
if (area <= 250)
{
    Console.WriteLine("The classroom is small.");
}

if (area < 650 && area > 250)
{
    Console.WriteLine("The classroom is medium.");
}

if (area >= 650)
{
    Console.WriteLine("The classroom is large.");
}

double volume = (height * width * length);

Console.WriteLine("The volume of the classroom is " + volume);

