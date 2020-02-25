using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_A02
{
   public class TriangleSolver
    {
        public string analyze (int side1, int side2, int side3)
        {
            
            string typeOfTriangle= " ";


            //if (side1 + side2 <= side3 || side1 + side3 <= side2 ||  side2 + side3 <= side1)
            //{

            //    Console.WriteLine("Numbers are NOT Valid and Do NOT Form a Triangle");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are Valid and Form a Triangle");


            //}

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                typeOfTriangle += "Error.. Please Enter all Positive Integers";
                return typeOfTriangle;
            }
            else if (side1 + side2 <= side3 || side2 + side3 <= side1 || side3 + side1 <= side2)
            {
                typeOfTriangle += "Numbers are NOT Valid and Do NOT Form a Triangle";
                return typeOfTriangle;
            }
            else 
            {
               Console.WriteLine("Numbers are Valid and Do Form a Triangle");
                if (side1 == side2 && side2 == side3)
                {
                    typeOfTriangle += "Its an equilateral triangle";
                    return typeOfTriangle;

                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    typeOfTriangle += "Its an isosceles triangle";
                    return typeOfTriangle;

                }
                else
                {
                    typeOfTriangle += "Its an scalene triangle";
                    return typeOfTriangle;
                }
                
            }
          

        }
    }
}
