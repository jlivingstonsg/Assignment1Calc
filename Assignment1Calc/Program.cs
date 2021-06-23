using System;
using System.Globalization;


namespace Assignment1Calc
{
    class Program
    {
        // Initialize instance of Calc for nuse inside class Program
        private static Calc calc = new Calc();

        static void Main()
        {
            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Calculate two numbers with 1.Addition, 2.Subtraction, 3.Multiplication, 4.Division  ");
                    // Ask the user to type the first and second number.
                    Console.Write("Enter first number: ");
                    double firstnumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double lastnumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter calculation assignment number (or 0 to exit): ");
                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                 
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseSum( firstnumber,  lastnumber);
                            break;
                        case 2:
                            RunExerciseSub(firstnumber, lastnumber);
                            break;
                        case 3:
                            RunExerciseMult(firstnumber, lastnumber);
                            break;
                        case 4:
                            RunExerciseDiv(firstnumber, lastnumber);
                            break;
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("1. That is not a valid input!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2. That is not a valid input!");
                    Console.ResetColor();
                }

            }//while (keepAlive)

        }//static void Main(string[] args)

        private static void RunExerciseSum(double firstnumber, double lastnumber)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            double sum6 = calc.Sum(firstnumber, lastnumber);
            Console.WriteLine("Sum (+): " + firstnumber + " + " + lastnumber + " = " + sum6.ToString("N", nfi));
        }

        private static void RunExerciseSub(double firstnumber, double lastnumber)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;          
            double sub = calc.Sub(firstnumber, lastnumber);
            Console.WriteLine("Sum (+): " + firstnumber + " - " + lastnumber + " = " + sub.ToString("N", nfi));
        }

        private static void RunExerciseMult(double firstnumber, double lastnumber)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            double Mult = calc.Mult(firstnumber, lastnumber);
            Console.WriteLine("Sum (+): " + firstnumber + " * " + lastnumber + " = " + Mult.ToString("N", nfi));
        }

        private static void RunExerciseDiv(double firstnumber, double lastnumber)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;       
                double Div = calc.Div(firstnumber, lastnumber);
                Console.WriteLine("Sum (+): " + firstnumber + " * " + lastnumber + " = " + Div.ToString("N", nfi));        
        }
    }//class Program

   
    public class Calc
    {
        public double Sum(double firstnumber, double lastnumber)
        {
            double sum = firstnumber + lastnumber;
            return sum;
        }

        public double Sub(double firstnumber, double lastnumber)
        {
            double sub = firstnumber - lastnumber;
            return sub;
        }

        public double Mult(double firstnumber, double lastnumber)
        {
            double mult = firstnumber * lastnumber;
            return mult;
        }

        public double Div(double firstnumber, double lastnumber)
        {
            if (lastnumber == 0)
            {
                throw new Exception("You can not divide with 0. ");
            }
            else
            {
                double div = firstnumber / lastnumber;
                return div;
            }
        }
    }//class Calc
}//namespace Assignment1Calc
