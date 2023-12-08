using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class StringExcercie
    {
        // Write a program in C# Sharp to compare two strings without using a string library functions.
        public void CompareString()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            bool areEqual = true;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        areEqual = false;
                        break;

                    }


                }
            }
            else
            {
                areEqual = false;
            }

            if (areEqual)
            {
                Console.WriteLine("Both strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }

        //        Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
        //Test Data :
        //Input number of strings :3
        //Input 3 strings below :
        //abcd
        //zxcv
        //mnop
        //Expected Output :
        //After sorting the array appears like : 
        //abcd
        //mnop
        //zxcv

        public void SortString()
        {

            Console.Write("Input number of strings: ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Input {0} strings below:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input string {i + 1}: ");
                arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nAfter sorting the array appears like:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        // Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case
        public void IsAlphabet()
        {
            Console.WriteLine("enter a chareter");
            char inputChar = Console.ReadKey().KeyChar;

            if (char.IsLetter(inputChar))
            {
                Console.WriteLine("\nIt is an alphabet.");

                if (char.IsUpper(inputChar))
                {
                    Console.WriteLine("It is an uppercase alphabet.");
                }
                else
                {
                    Console.WriteLine("It is a lowercase alphabet.");
                }
            }
            else
            {
                Console.WriteLine("\nIt is not an alphabet.");
            }
        }
    }

    
}

