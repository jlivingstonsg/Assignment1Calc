using System;
using System.Globalization;


namespace Assignment1Calc
{
    class Program
    {
        static void Main()
        {
            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {

                    Console.WriteLine("Calculate two numbers with 1.Addition, 2.Subtraction, 3.Multiplication, 4.Division  ");

                    Console.Write("Enter calculation assignment number (or 0 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseSum();
                            break;
                        case 2:
                            RunExerciseSub();
                            break;
                        case 3:
                            RunExerciseMult();
                            break;
                        case 4:
                            RunExerciseDiv();
                            break;
                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
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
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }

            }//while (keepAlive)

        }//static void Main(string[] args)

        private static void RunExerciseSum()
        {

            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            // Ask the user to type the first and second number.
            Console.Write("Enter first number: ");
            double firstnumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double lastnumber = Convert.ToDouble(Console.ReadLine());
            //----------------------
            double sum6 = firstnumber + lastnumber;
            Console.WriteLine("Sum (+): " + firstnumber + " + " + lastnumber + " = " + sum6.ToString("N", nfi));
            //-----------------------
        }


        private static void RunExerciseSub()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            // Ask the user to type the first and second number.
            Console.Write("Enter first number: ");
            double firstnumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double lastnumber = Convert.ToDouble(Console.ReadLine());
            //----------------------
            double sub = firstnumber - lastnumber;
            Console.WriteLine("Sum (+): " + firstnumber + " - " + lastnumber + " = " + sub.ToString("N", nfi));
        }

        private static void RunExerciseMult()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            // Ask the user to type the first and second number.
            Console.Write("Enter first number: ");
            double firstnumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double lastnumber = Convert.ToDouble(Console.ReadLine());
            //----------------------
            double Mult = firstnumber * lastnumber;
            Console.WriteLine("Sum (+): " + firstnumber + " * " + lastnumber + " = " + Mult.ToString("N", nfi));
        }

        private static void RunExerciseDiv()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            // Ask the user to type the first and second number.
            Console.Write("Enter first number: ");
            double firstnumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number(not 0): ");
            double lastnumber = Convert.ToDouble(Console.ReadLine());
            //----------------------
            if (lastnumber == 0)
            {
                Console.WriteLine("You can not divide with 0. ");
            }
            else
            {
                double Div = firstnumber / lastnumber;
                Console.WriteLine("Sum (+): " + firstnumber + " * " + lastnumber + " = " + Div.ToString("N", nfi));

            }


        }


    }//class Program

}//namespace Assignment1Calc
