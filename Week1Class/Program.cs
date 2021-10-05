using System;

namespace Week1Class
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string response;
            do
            {
                Console.WriteLine("Enter a numerical grade:");
                int grade = int.Parse(Console.ReadLine());
                char letterGrade;

                if (grade < 60)
                {
                    letterGrade = 'F';
                }
                else if (grade <= 66 && grade >= 60)
                {
                    letterGrade = 'D';
                }
                else if (grade <= 79 && grade >= 67)
                {
                    letterGrade = 'C';
                }
                else if (grade <= 87 && grade >= 80)
                {
                    letterGrade = 'B';
                }
                else letterGrade = 'A';

                Console.WriteLine("Letter Grade: " + letterGrade);
                Console.WriteLine("Continue? (y/n)");
                response = Console.ReadLine();
            }
            while (response == "y");
            */


            string response;

            do
            {

                Console.WriteLine("Enter Length:");
                double roomLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                double roomWidth = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height:");
                double roomHeight = double.Parse(Console.ReadLine());

                double area = roomLength * roomWidth;
                double perimeter = 2 * roomLength + 2 * roomWidth;
                double volume = area * roomHeight;
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                double carpetTiles = area / 5;
                double paintCansPer = perimeter / 5; //paint calculated using only perimeter
                double paintCans = (perimeter * roomHeight + area) / 5; // height included in calculation of paint required. added in area to account for the ceiling

                Console.WriteLine("Carpet Tiles: " + carpetTiles);
                Console.WriteLine("Paint: " + paintCansPer);
                Console.WriteLine("Paint including height and ceiling: " + paintCans);

                Console.WriteLine("Continue? (y/n)");
                response = Console.ReadLine().ToLower();


            }
            while (response == "y");


        }
        
    }

}

// 0) ask the user for a radius of a circle
// 1) get user input     
//2) convert the input into a double (cuz we want the decimals)
//3) run the formula, and store the result
//4) print result to the console

/*Console.WriteLine("Welcome to the circle app");
Console.WriteLine("Please input a radius: ");
Console.WriteLine();

string input = Console.ReadLine();
double rad = double.Parse(input);

double result = Math.PI * rad * rad;

Console.WriteLine($"Area of your circle: {result}");
*/
/* int check = 1;
 check++;
 Console.WriteLine(check);
 double check2 = (double) check * 1.0;
 Console.WriteLine(check);
 Console.WriteLine(check2);
 double y = (double)check;
 Console.WriteLine(y);*/

// Input is received from the user using Console.Writeline to prompt user for input, console.Readline to get the users input, and then the input is parsed in order to convert it to a double
// The calculations are made using the variables that stored the user input, and putting them into the formulas for perimeter, area, and volume.
// The output of the code is displayed back to the user using the Console.WriteLine method, writing a short string plus the variable we are trying to show in each WriteLine statement.