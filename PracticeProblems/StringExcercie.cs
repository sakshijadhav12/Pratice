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
                Console.WriteLine("It is an alphabet.");

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
                Console.WriteLine("It is not an alphabet.");
            }
        }

        public void CompareSubString()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            Console.WriteLine("Enter the starting index for the first substring:");
            int startIndex1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the first substring:");
            int length1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the starting index for the second substring:");
            int startIndex2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of the second substring:");
            int length2 = int.Parse(Console.ReadLine());
            string subStr1 = str1.Substring(startIndex1, length1);
            string subStr2 = str2.Substring(startIndex2, length2);
            int result = String.Compare(subStr1, subStr2);
            if (result < 0)
            {
                Console.WriteLine($"{subStr1} is less than {subStr2}");
            }
            else if (result > 0)
            {
                Console.WriteLine($"{subStr1} is greater than {subStr2}");
            }
            else
            {
                Console.WriteLine($"{subStr1} is equal to {subStr2}");
            }

        }

        public void CompareLastName()
        {
            Console.WriteLine("Enter the full name of the first person: ");
            string fullName1 = Console.ReadLine();

            Console.WriteLine("Enter the full name of the second person: ");
            string fullName2 = Console.ReadLine();

            
            string lastName1 = ExtractLastName(fullName1);
            string lastName2 = ExtractLastName(fullName2);
            string[] sortedLastNames = { lastName1, lastName2 };
            Array.Sort(sortedLastNames);
            Console.WriteLine("Sorted alphabetically by last name:");
            foreach (var lastName in sortedLastNames)
            {
                Console.WriteLine(lastName);
            }
        }
        static string ExtractLastName(string fullName)
        {
            string[] nameParts = fullName.Split(' ');
            if (nameParts.Length > 1)
            {
                return nameParts[nameParts.Length - 1];
            }
            else
            {
           
                return nameParts[0];
            }
        }

        public void LengthOfSubString()
        {
            string[] testStrings = {
            "aaaaaabbbbccc",
            "BDEFGAABEF",
            "Python",
            
        };
            static int LengthOfLongestSubstring(string s)
            {
                int n = s.Length;
                int maxLength = 0;
                Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

                for (int end = 0, start = 0; end < n; end++)
                {
                    if (charIndexMap.ContainsKey(s[end]))
                    {
                        start = Math.Max(charIndexMap[s[end]] + 1, start);
                    }

                    maxLength = Math.Max(maxLength, end - start + 1);
                    charIndexMap[s[end]] = end;
                }

                return maxLength;
            }

            foreach (string testString in testStrings)
            {
                Console.WriteLine("Original String: " + testString);
                Console.WriteLine("Length of the longest substring without repeating characters of the said string:");
                Console.WriteLine(LengthOfLongestSubstring(testString));
                Console.WriteLine();
            }
        }
    }

    
}

