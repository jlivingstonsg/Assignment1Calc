using System;
using System.Globalization;


namespace Assignment1Calc
{
    class Program
    {
        // Initialize instance of Calc for nuse inside class Program
        private static readonly Calc calc = new Calc();

        static void Main()
        {
            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Calculate numbers with 1.Addition, 2.Subtraction, 3.Multiplication, 4.Division  ");
                    // Ask the user to type the first and second number.
                   
                    Console.Write(" Enter calculation assignment number (or 0 to exit): ");
                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                 
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
                            Console.WriteLine(" 1. That is not a valid input!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine(" Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" 2. That is not a valid input!");
                    Console.ResetColor();
                }

            }//while (keepAlive)

        }//static void Main(string[] args)

        private static void RunExerciseSum()
        {
            Console.Write(" Write numbers (comma-separeted) who will be added. \n Your numbers: ");
            string arraysumstringinput = (Console.ReadLine());
            int[] arraysuminput = Array.ConvertAll(arraysumstringinput.Split(','), int.Parse);
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            int totsum = calc.SumSub(arraysuminput);           
            Console.WriteLine(" Sum: " + totsum.ToString("N", nfi));
        }

        private static void RunExerciseSub()
        {
            Console.Write(" Write numbers (comma-separeted) who will be subtracted. \n Your numbers: ");
            string arraysubstringinput = (Console.ReadLine());
            double[] arraysubinput = Array.ConvertAll(arraysubstringinput.Split(','), double.Parse);
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;            
            double totsub = calc.SumSub(arraysubinput);           
            Console.WriteLine(" Subtract : " + totsub.ToString("N", nfi));
        }

        private static void RunExerciseMult()
        {
            Console.Write(" Enter first number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter second number: ");
            int lastnumber = Convert.ToInt32(Console.ReadLine());

            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            double Mult = calc.Mult(firstnumber, lastnumber);
            Console.WriteLine(" Multiplication (*): " + firstnumber + " * " + lastnumber + " = " + Mult.ToString("N", nfi));
        }

        private static void RunExerciseDiv()
        {
            Console.Write(" Enter first number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter second number: ");
            int lastnumber = Convert.ToInt32(Console.ReadLine());

            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;       
                double Div = calc.Div(firstnumber, lastnumber);
                Console.WriteLine(" Division (/): " + firstnumber + " / " + lastnumber + " = " + Div.ToString("N", nfi));        
        }
    }//class Program

   
    public class Calc
    {
        public int SumSub(int[] arraysuminput)
        {

            int totsum = 0;
            for (int i = 0; i < arraysuminput.Length; i++)
            {
                totsum = arraysuminput[i] + totsum;
            }
            return totsum;
        }

        public double SumSub(double[] arraysubinput)
        {

            double totsub = arraysubinput[0];
            for (int i = 1; i < arraysubinput.Length; i++)
            {
                totsub = totsub - arraysubinput[i];
            }
            return totsub;
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
