using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_A02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool meneBool = false;
            string userSelection;
            int Side1;
            int Side2;
            int Side3;
            do
            {
                try
                {
                    Console.WriteLine("1. Enter Triangle dimensions");
                    Console.WriteLine("2. Exit");

                    userSelection = Convert.ToString(Console.ReadLine());

                    if (userSelection == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Please Enter the First Intger");
                        Side1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please Enter the second Intger");
                        Side2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please Enter the third Intger");
                        Side3 = Convert.ToInt32(Console.ReadLine());

                        TriangleSolver triangleSolver = new TriangleSolver();

                        Console.WriteLine("Results: " + triangleSolver.analyze(Side1, Side2, Side3));



                    }
                    else if (userSelection == "2")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong Input.. Please Try Again");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Please Select 1 or 2" + ex);
                }
            } while (meneBool == false);
          
           

            Console.ReadKey();

        }
    }
}
