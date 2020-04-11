using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to GPA Calculator");

            bool keepgoing = true;
            
            while (keepgoing)
            {
                Console.WriteLine("Please enter the following data in whole numbers");

                string input = "";
                int A_Credits = 0;
                int Am_Credits = 0;
                int Bp_Credits = 0;
                int B_Credits = 0;
                int Bm_Credits = 0;
                int Cp_Credits = 0;
                int C_Credits = 0;
                int Cm_Credits = 0;
                int Dp_Credits = 0;
                int D_Credits = 0;
                int F_Credits = 0;
                int Total_Credits = 0;

                Console.WriteLine("Enter the number of credits of either A or A+");
                input = Console.ReadLine();
                A_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of A- credits");
                input = Console.ReadLine();
                Am_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of B+ credits");
                input = Console.ReadLine();
                Bp_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of B credits");
                input = Console.ReadLine();
                B_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of B- credits");
                input = Console.ReadLine();
                Bm_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of C+ credits");
                input = Console.ReadLine();
                Cp_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of C credits");
                input = Console.ReadLine();
                C_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of C- credits");
                input = Console.ReadLine();
                Cm_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of D+ credits");
                input = Console.ReadLine();
                Dp_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of D credits");
                input = Console.ReadLine();
                D_Credits = int.Parse(input);

                Console.WriteLine("Enter the number of F credits");
                input = Console.ReadLine();
                F_Credits = int.Parse(input);

                Console.WriteLine("Enter the total number of credits");
                input = Console.ReadLine();
                Total_Credits = int.Parse(input);

                GPA_Calculator GPA = new GPA_Calculator();

                decimal Calculated_GPA = GPA.CalculateGPA(A_Credits, Am_Credits, Bp_Credits, B_Credits, Bm_Credits, Cp_Credits, C_Credits, Cm_Credits, Dp_Credits, D_Credits, F_Credits, Total_Credits);
                Console.WriteLine("Your GPA is " + Calculated_GPA);
                

                Console.WriteLine("Do you want to calculate another GPA? Enter Yes or No");
                string NewGPA = Console.ReadLine();

                if (NewGPA == "No")
                {
                    keepgoing = false;
                }

            }
            Console.Write("The program is finished");

        }
    }
}