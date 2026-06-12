using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_concept_of.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 2
            //1. Write a program to change the case of entered character.

            //Console.Write("Enter a character:");
            //char inputChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //if (char.IsLower(inputChar))
            //{
            //    char upperChar = char.ToUpper(inputChar);
            //    Console.WriteLine("Uppercase: " + upperChar);
            //}
            //else if (char.IsUpper(inputChar))
            //{
            //    char lowerChar = char.ToLower(inputChar);
            //    Console.WriteLine("Lowercase: " + lowerChar);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a letter.");
            //}

            //2. Write a program to replace lowercase character to uppercase and ViceVersa in a string.

            //string input = "Hello World!";
            //string result = new string(input.Select(c =>
            //char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());

            //Console.WriteLine($"Original: {input}");
            //Console.WriteLine($"Result:   {result}");

            //3. Take 2 string from user, and validate 2nd string is contains by 1st or not.

            //Console.Write("Enter the first string: ");
            //Console.ReadLine();
            //Console.Write("Enter the second string: ");
            //Console.ReadLine();
            //if (Console.ReadLine().Contains(Console.ReadLine()))
            //{
            //    Console.WriteLine("The second string is contained in the first string.");
            //}
            //else
            //{
            //    Console.WriteLine("The second string is not contained in the first string.");
            //}


            //4. Find the Second Largest Element in an Array.

            //int n = 5;
            //Console.Write("Enter the number of elements: ");
            //Console.ReadLine();
            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int largest = arr[0];
            //int secondLargest = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = arr[i];
            //    }
            //    else if (arr[i] > secondLargest && arr[i] < largest)
            //    {
            //        secondLargest = arr[i];
            //    }
            //}
            //Console.WriteLine("Second Largest Element: " + secondLargest);


            // 5. Simple Calculator (else-if Ladder & Switch Case)

                int num1, num2;
                Console.Write("Enter First Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Operator (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                if (op == '+')
                {
                    Console.WriteLine("Result = " + (num1 + num2));
                }
                else if (op == '-')
                {
                    Console.WriteLine("Result = " + (num1 - num2));
                }
                else if (op == '*')
                {
                    Console.WriteLine("Result = " + (num1 * num2));
                }
                else if (op == '/')
                {
                    if (num2 != 0)
                        Console.WriteLine("Result = " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine("Invalid Operator!");
                }
        }
    }
}
