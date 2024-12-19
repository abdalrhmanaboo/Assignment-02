using System;
using System.ComponentModel;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            // Console.Write("Enter Number : ");
            //int Number = int.Parse(Console.ReadLine());
            //if (Number % 3 == 0 && Number % 4 == 0)
            //   Console.WriteLine("Yes");
            //else
            //   Console.WriteLine("No");

            #endregion
            #region  2_Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter Number : ");
            //int Number = int.Parse(Console.ReadLine());
            //string Message = Number < 0 ? "negative" : "positive";
            //Console.WriteLine(Message);
            #endregion
            #region 3_Write a program that takes 3 integers from the user then prints the max element and the min element
            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //int num3 = int.Parse(Console.ReadLine());
            //int max = num1;
            //if (num2 > max)
            //{
            //  max = num2;
            //}
            //if (num3 > max)
            //{
            //   max = num3;
            //}


            //int min = num1;
            //if (num2 < min)
            //{
            //  min = num2;
            //}
            //if (num3 < min)
            //{
            //   min = num3;
            //}
            //Console.WriteLine("Max Number = " + max);
            //Console.WriteLine("Min Number = " + min);
            #endregion
            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter Number: ");
            //int num =int.Parse (Console.ReadLine());
            //string Massage = num % 2 == 0 ? "EVEN":"ODD";
            //Console.WriteLine(Massage);
            #endregion
            #region  5-Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter char: ");
            // char character = char.Parse( Console.ReadLine());
            //string Massege = character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' ? "Vowel" : "Consonant";
            //Console.WriteLine(Massege);           
            #endregion
            #region 7- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.
            //Console.Write("Enter Number: ");
            //int number = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= 12; i++)
            //{
            //  Console.WriteLine($"{number} x {i} = {number * i}");
            //}

            #endregion
            #region 9-Write a program that takes two integers then prints the power.
            //Console.Write("Enter num1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter num2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= num2; i++)
            //{
            //   result *= num1; // ضرب النتيجة بالعدد الأساسي
            //}
            //Console.WriteLine($"{num1} raised to the power of {num2} is: {result}");
            //}
            #endregion
            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            // Console.Write("Enter marks for subject 1: ");
            //int subject1 = int.Parse(Console.ReadLine());

            //            Console.Write("Enter marks for subject 2: ");
            //          int subject2 = int.Parse(Console.ReadLine());
            //
            //        Console.Write("Enter marks for subject 3: ");
            //      int subject3 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter marks for subject 4: ");
            //  int subject4 = int.Parse(Console.ReadLine());

            //Console.Write("Enter marks for subject 5: ");
            // int subject5 = int.Parse(Console.ReadLine());


            // int totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;


            //double averageMarks = totalMarks / 5.0;

            //double percentage = (totalMarks / 500.0) * 100;


            //Console.WriteLine("Total marks = " + totalMarks);
            //Console.WriteLine("Average marks = " + averageMarks);
            //Console.WriteLine("Percentage = " + percentage + "%");

            #endregion
            #region 11 - Write a program to input the month number and print the number of days in that month.
            /*Console.Write("Enter the month number (1-12): ");
            int month = int.Parse(Console.ReadLine());


            int daysInMonth = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;

                case 2:

                    Console.Write("Enter the year: ");
                    int year = int.Parse(Console.ReadLine());
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                    break;

            }
              Console.WriteLine($"The number of days in month {month} is: {daysInMonth}");
*/
            #endregion
            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            /*Console.Write("Enter x1, y1: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2, y2: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Enter x3, y3: ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

             
            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);

             
            if (slope1 == slope2)
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }
*/
            #endregion
            #region 18-
            /*Console.Write("Enter the time taken to complete the task (in hours): ");
            double timeTaken = double.Parse(Console.ReadLine());

             
            if (timeTaken >= 2 && timeTaken <= 3)
            {
                Console.WriteLine("The worker is highly efficient.");
            }
            else if (timeTaken > 3 && timeTaken <= 4)
            {
                Console.WriteLine("The worker is instructed to increase their speed.");
            }
            else if (timeTaken > 4 && timeTaken <= 5)
            {
                Console.WriteLine("The worker is provided with training to enhance their speed.");
            }
            else if (timeTaken > 5)
            {
                Console.WriteLine("The worker is required to leave the company.");
            }
            else
            {
                Console.WriteLine("Invalid input. Time must be greater than 0.");
            }*/
            #endregion
            #region 21-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            /* int a = 10;
             int b = a;     


             a = 20;


             Console.WriteLine("Value of a: " + a);   
             Console.WriteLine("Value of b: " + b);   
 */
            #endregion
            #region 22-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen



            #endregion
            #region 22-Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            //A value 1 will be assigned to d
            #endregion
            #region 24-Which of the following is the correct output for the C# code given below?
            //  Console.WriteLine(13 / 2 + " " + 13 % 2);
            //16
            #endregion
            #region 25-What will be the output of the C# code given below?

            //int num = 1, z = 5;


            //if (!(num <= 0))
              //  Console.WriteLine(++num + z++ + " " + ++z);
            //else
              //  Console.WriteLine(--num + z-- + " " + --z);
            //7 7




            #endregion
        }

    }
    }

