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
            {
                

                while (true)
                {
                    MenuSelection();
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
                        Console.WriteLine("Have a nice day.");
                        break;
                    }
                    else

                    {

                        Console.WriteLine("Please enter a number between 1-4");

                    }

                }

                Console.ReadKey();

            }
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

            else if (Lname.ToLower() == "potter")

            {
                studentCost[spot] = cost / 2;
                Students[spot] = student;
            }

            else if (student.ToLower().Contains("longbottoms") || spot < 10)



            {
                studentCost[spot] = cost - cost;
                Students[spot] = student;
                if (spot < 10)
                {
                    Console.WriteLine(student[spot] + "is now enrolled and will need to pay £ 0.");
                }
                else
                {
                    Console.WriteLine(student[spot] + "is now enrolled and will need to pay £ 200.");
                }
            }

            else if (student.ToLower().Contains("tom") || student.ToLower().Contains("riddle") || student.ToLower().Contains("voldemort"))



            {
                Console.WriteLine("Red Alert!!! He who must not be named!!!");
                studentCost[spot] = cost;
                Students[spot] = student;
            }

            
            else
            {
                studentCost[spot] = cost;
                Students[spot] = student;
                Console.WriteLine(Students + "is now enrolled and will need to pay £ 200.");

            }

        }
        static void PrintStudents()

        {

            for (int i = 0; i < Students.Length; i++)

            {
                if (Students[i] != null)

                {
                    Console.WriteLine(i + 1 + " " + Students[i] + " owes £" + studentCost[i]);

                }

            }

        }
        static void MenuSelection()

        {
            int Counter = 0;

            for (int i = 0; i < Students.Length; i++)

            {
                if (Students[i] != null)

                {
                    Counter++;

                }

            }
            if (Counter == 15)
            {
                Console.WriteLine("2. Unenroll a student");
                Console.WriteLine("3. Print out list of students");
                Console.WriteLine("4. Exit");
            }
            else if (Counter == 0)
            {
                Console.WriteLine("1. Enroll a student");
                Console.WriteLine("3. Print out list of students");
                Console.WriteLine("4. Exit");
            }

            else
            {
                Console.WriteLine("1. Enroll a student");
                Console.WriteLine("2. Unenroll a student");
                Console.WriteLine("3. Print out list of students");
                Console.WriteLine("4. Exit");
            }
        }


    }

}

