//Justin Review 1-10-23

Console.WriteLine("Welcome to the room calcalator");

//User input
Console.WriteLine("What is the length of the classroom in ft?");
double length1 = double.Parse(Console.ReadLine());
Console.WriteLine("What is the width of the classroom in ft?");
double width1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a  height");
double height1 = double.Parse(Console.ReadLine());

//Calculations
double area1 = length1 * width1;
double perimeter = 2 * (length1 + width1);
double volume1 = width1 * length1 * height1;
double surfacArea = 2*(width1 * length1) + (height1 * length1) + (height1 * width1);

//Display
Console.WriteLine("Area: " + area1);
Console.WriteLine("Perimeter: " + perimeter);
Console.WriteLine("Volume: " + volume1);
Console.WriteLine("Surface Area: " + surfacArea);

//Room size
if (area1 <= 250)
{
    Console.WriteLine("This room is small.");
}
else if(area1 > 250 && area1 < 650)
{
    Console.WriteLine("This room is medium.");
}
//oth cover all other possibilities
//else if(area >= 650)
else
{
    Console.WriteLine("This room is large.");
}




//Carissa 1-9-23
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

