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
                    Console.WriteLine(" Calculate numbers \n " +
                        "Addition:       1. Two numbers, 2. Many numbers \n " +
                        "Subtraction:    3. Two numbers, 4. Many numbers \n " +
                        "Multiplication: 5. Two numbers \n " +
                        "Division:       6. Two numbers  ");
                    // Ask the user to type the first and second number.
                    Console.WriteLine("--------------------------------------------------- ");

                    Console.Write(" Enter calculation assignment number (or 0 to exit): ");
                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                 
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseSum();
                            break;
                        case 2:
                            RunExerciseSumArray();
                            break;
                        case 3:
                            RunExerciseSub();
                            break;
                        case 4:
                            RunExerciseSubArray();
                            break;
                        case 5:
                            RunExerciseMult();
                            break;
                        case 6:
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

            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            // Ask the user to type the first and second number.
            Console.Write(" Enter first number: ");
            double firstnumber = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter second number: ");
            double lastnumber = Convert.ToDouble(Console.ReadLine());
            //----------------------
            double totsum = calc.SumInput(firstnumber, lastnumber);
            Console.WriteLine(" Sum (+): " + firstnumber + " + " + lastnumber + " = " + totsum.ToString("N", nfi));
            //-----------------------
        }


        private static void RunExerciseSumArray()
        {
            Console.Write(" Write numbers (comma-separeted) who will be added. \n Your numbers: ");
            string arraysumstringinput = (Console.ReadLine());
            double[] arraysuminput = Array.ConvertAll(arraysumstringinput.Split(','), double.Parse);
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            double totsum = calc.SumInput(arraysuminput);
            Console.WriteLine(" Sum: " + totsum.ToString("N", nfi));
        }



        private static void RunExerciseSub()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            // Ask the user to type the first and second number.
            Console.Write(" Enter first number: ");
            double firstnumber = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter second number: ");
            double lastnumber = Convert.ToDouble(Console.ReadLine());
            //----------------------            
            double totsum = calc.SubInput(firstnumber, lastnumber);
            Console.WriteLine(" Subtract (-): " + firstnumber + " - " + lastnumber + " = " + totsum.ToString("N", nfi));
            //-----------------------
        }


        private static void RunExerciseSubArray()
        {
            Console.Write(" Write numbers (comma-separeted) who will be subtracted. \n Your numbers: ");
            string arraysubstringinput = (Console.ReadLine());
            double[] arraysubinput = Array.ConvertAll(arraysubstringinput.Split(','), double.Parse);
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 4;
            double totsub = calc.SubInput(arraysubinput);
            Console.WriteLine(" Subtracted (-): " + totsub.ToString("N", nfi));
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
        public double SumInput(double suminput1, double suminput2)
        {
            double totsum = suminput1 + suminput2;            
            return totsum;
        }

        public double SumInput(double[] arraysuminput)
        {

            double totsum = 0;
            for (int i = 0; i < arraysuminput.Length; i++)
            {
                totsum = arraysuminput[i] + totsum;
            }
            return totsum;
        }

        public double SubInput(double subinput1, double subinput2)
        {
            double totsub = subinput1 - subinput2;
            return totsub;
        }

        public double SubInput(double[] arraysubinput)
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
