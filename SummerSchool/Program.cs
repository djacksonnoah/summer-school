using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {

        static string[] Students = new string[15];

        static void Main(string[] args)
        {
            while (true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
            
            if (choice == 1)

            {
                EnrollStudent(); //test comment

            }

            else if (choice == 2)

            {

                UnenrollStudent();
            }

            else if (choice == 3)

            {

                PrintStudents();

            }

            else if (choice == 4)

            {

                break;
            }
            else

            {
                    
                Console.WriteLine("Please enter a number between 1-4");

                     }

                }

                Console.ReadKey();

            }

    private static void UnenrollStudent()

    {
    }

    static int GetNextAvailableSpot()

    {
        for (int i = 0; i < Students.Length; i++)


        {
            if (Students[i] == null)


            {

                return 1;
            }
        }

        return -1;
    }
        static void EnrollStudent()

        {

                Console.WriteLine("What is the student's name you want to enroll?");

                string student = Console.ReadLine();

                int spot = GetNextAvailableSpot();

                Students[spot] = student;

            }
                           

            static void PrintStudents()

        {

            for (int i = 0; 1 < Students.Length; i++)

            {
                Console.WriteLine(Students);

            }

        }

    }

}
   
