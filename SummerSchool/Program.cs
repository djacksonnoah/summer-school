﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] array = new string [] { };

            Console.WriteLine( "Chose a number 1) Enroll a student  2) Unenroll a student 3) Print out the list of enrolled students 4) Exit");

            int chooseNumber =  Convert.ToInt32(Console.ReadLine());

            if (chooseNumber == 1)

     
              {

                Console.WriteLine("What is the name of the student to enroll?");
               
                string[] name = new string[15];
                int i, j = 0;


                // Storing users name and amount owed in two different array. 
                for (i = 0; i < 15; i++)
                {
                    Console.Write("\n\nEnter student's name:\t");
                    name[i] = Console.ReadLine();

                    Console.WriteLine(name[i]);
                    Console.WriteLine( "is now enrolled and will need to pay $200");
                    Console.ReadKey();
                }

               
   

               
            }

            else if (chooseNumber == 2)

            {
                Console.WriteLine("What is the student's first and last name that you want to unenroll?");
            }

            else if (chooseNumber == 3)

            {

                Console.WriteLine("The list of students is:");

            }

            else if (chooseNumber == 4)

            {
                Console.WriteLine("Have a nice day");

            }

            else

            {
                Console.WriteLine("Please choose a number between 1-4!");

            }

            Console.ReadKey();
        }
    }
}
