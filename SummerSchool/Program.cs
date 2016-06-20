using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static double[] studentCost = new double[15];
        static string[] Students = new string[15];

        static void Main(string[] args)
        {
            while (true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)

                {
                    EnrollStudent();

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
            PrintStudents();
            Console.WriteLine("Number");
            int reduceStudent = Convert.ToInt32(Console.ReadLine());
            Students[reduceStudent - 1] = null;

        }

        static int GetNextAvailableSpot()

        {
            for (int i = 0; i < Students.Length; i++)


            {
                if (Students[i] == null)


                {

                    return i;
                }
            }

            return -1;
        }
        static void EnrollStudent()

        {

            Console.WriteLine("What is the student's name you want to enroll?");

            string student = Console.ReadLine();

            int spot = GetNextAvailableSpot();
            double cost = 200;

            var splitNames = student.Split(' ');
            string Fname = splitNames[0];
            string Lname = splitNames[1];

            if (Lname.ToLower() == "malfoy")
            {
                Console.WriteLine("Enrollment declined");
            }
            // need rest of else if for special names

            else
            {
                studentCost[spot] = cost;
                Students[spot] = student;

            }

        }
            static void PrintStudents()

        {

                for (int i = 0; i < Students.Length; i++)

                {
                    if (Students[i] != null)

                    {
                        Console.WriteLine(i + 1 + " " + Students[i] + " owes $" + studentCost[i]);

                    }

                }

            }

        }

    }

