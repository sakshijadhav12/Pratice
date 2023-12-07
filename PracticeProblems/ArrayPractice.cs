using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticeProblems
{
    public class ArrayPractice
    {

        //        Write a C# Sharp program that stores elements in an array and prints them.
        //Test Data:
        //Input 10 elements in the array:
        //element - 0 : 1
        //element - 1 : 1
        //element - 2 : 2
        //.......'
        //Expected Output :
        //Elements in array are: 1 1 2 3 4 5 6 7 8 9

        public void PrintArray()
        {
            int[] MyArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("element - " + i + ":");
                MyArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var i in MyArray)
            {
                Console.WriteLine("elements are:" + i);
            }

        }

        //        Write a C# Sharp program to copy the elements of one array into another array.
        //Test Data :
        //Input the number of elements to be stored in the array :3
        //Input 3 elements in the array :
        //element - 0 : 15
        //element - 1 : 10
        //element - 2 : 12
        //Expected Output:
        //The elements stored in the first array are :
        //15 10 12
        //The elements copied into the second array are :
        //15 10 12

        public void CopyArray()
        {
            int[] arr = new int[3];
            int[] copyArr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter array element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                copyArr[i] = arr[i];
            }
            Console.WriteLine("elements entered in First array : ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("elements copied in second array : ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{copyArr[i]}");
            }
        }

        //        Write a C# Sharp program to count the frequency of each element in an array.
        //Test Data :
        //Input the number of elements to be stored in the array :3
        //Input 3 elements in the array :
        //element - 0 : 25
        //element - 1 : 12
        //element - 2 : 43
        //Expected Output :
        //Frequency of all elements of array :
        //25 occurs 1 times
        //12 occurs 1 times
        //43 occurs 1 times

        public void CountFrequency()
        {
            int[] array = new int[3];
            int[] freqarray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Input Element {0} of array:", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
                freqarray[i] = -1;
            }
            for (int i = 0; i < 3; i++)
            {
                int count = 1; 

                for (int j = i + 1; j < 3; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        freqarray[j] = 0; 
                    }
                }
                if (freqarray[i] != 0)
                {
                    freqarray[i] = count;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (int i = 0; i < 3; i++)
            {
                if (freqarray[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", array[i], freqarray[i]);
                }
            }
        }

        //        Write a C# Sharp program to sort array elements in descending order.
        //Test Data :
        //Input the size of array : 3
        //Input 3 elements in the array :
        //element - 0 : 5
        //element - 1 : 9
        //element - 2 : 1
        //Expected Output :
        //Elements of the array in sorted descending order:
        //9 5 1

        public void SortArray()
        {
            int[] array = new int[3];
            for(int i = 0; i<3;i++)
            {
                Console.WriteLine("enter elements of array");
                array[i] = Convert.ToInt32(Console.ReadLine());
           }
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Array elements in descending order:");

            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
        }

        //        Write a C# Sharp program to find the second largest element in an array.
        //Test Data :
        //Input the size of array : 5
        //Input 5 elements in the array :
        //element - 0 : 2
        //element - 1 : 9
        //element - 2 : 1
        //element - 3 : 4
        //element - 4 : 6
        //Expected Output :
        //The Second largest element in the array is: 6

        public void SecondLargest()
        {
            int[] array = new int[5];
            for(int i = 0; i<5;i++)
            {
                Console.WriteLine("Enterr Elements of Array");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            int secondLargest = array[array.Length - 2];
            Console.WriteLine("second Largest element of array is " + secondLargest);
        }

        //Write a C# Sharp program to get only odd values from a given integer array
        public void FindOddValues()
        {
            int[] array = { 2, 7, 8, 9, 4, 6, 2, 5, 9, 12, 17 };
            int countOddValues = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    countOddValues++;
                }
            }
            int[] oddValues = new int[countOddValues];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddValues[index] = array[i];
                    index++;
                }
            }

            Console.WriteLine("Original values of an array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] );
            }

            Console.WriteLine("\nOdd values of an array:");
            for (int i = 0; i < oddValues.Length; i++)
            {
                Console.WriteLine(oddValues[i] );
            }
        }

                //        Write a C# Sharp program for the subtraction of two matrixes.
                //Test Data :
                //Input the size of the square matrix(less than 5) : 2
                //Input elements in the first matrix :
                //element - [0],[0] : 5
                //element - [0],[1] : 6
                //element - [1],[0] : 7
                //element - [1],[1] : 8
                //Input elements in the second matrix :
                //element - [0],[0] : 1
                //element - [0],[1] : 2
                //element - [1],[0] : 3
                //element - [1],[1] : 4
                //Expected Output :
                //The First matrix is :

                //5 6
                //7 8
                //The Second matrix is :

                //1 2
                //3 4
                //The Subtraction of two matrix is :

                //4 4
                //4 4

        public void MatrixSubtraction()
        {
            Console.WriteLine("enter no. of rows of a matrix");
            int  rows= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no. of cloumns of a matrix");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            Console.WriteLine("enter values of first Matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at position ({i + 1}, {j + 1}): ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("enter values for second matrix");
            for(int i = 0; i<rows;i++)
            { 
                 for (int j= 0; j<cols; j++)
                {
                    Console.Write($"Enter element at position ({i + 1}, {j + 1}): ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            int[,] resultMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            Console.WriteLine("matrix1:");
            for(int i=0;i<rows;i++)
            {
                for(int j= 0;j<cols;j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("matrix2:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Result of Matrix Subtraction:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

            //        Write a C# Sharp program to find the sum of the left diagonals of a matrix.
            //Test Data:
            //Input the size of the square matrix : 2
            //Input elements in the first matrix :
            //element - [0],[0] : 1
            //element - [0],[1] : 2
            //element - [1],[0] : 3
            //element - [1],[1] : 4
            //Expected Output :
            //The matrix is :
            //1 2
            //3 4
            //Addition of the left Diagonal elements is :5

        public void SumOfLeftDiagonal()
        {
            Console.WriteLine("enter no. of rows of a matrix");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no. of cloumns of a matrix");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("enter values for matrix");
            for(int i = 0;i<rows;i++)
            {
                for(int j = 0;j<cols;j++)
                {
                    Console.WriteLine($"Enter element at position ({i + 1}, {j + 1}): ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("matrix:");
            
            for (int i=0;i<rows;i++)
            {
                for(int j =0;j<cols;j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < rows && i < cols; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine("Sum of left diagonal of matrix is: " + sum);
           
        }

            //        Write a C# Sharp program to calculate the determinant of a 3 x 3 matrix.
            //Test Data :
            //Input elements in the first matrix :
            //element - [0],[0] : 1
            //element - [0],[1] : 0
            //element - [0],[2] : -1
            //element - [1],[0] : 0
            //element - [1],[1] : 0
            //element - [1],[2] : 1
            //element - [2],[0] : -1
            //element - [2],[1] : -1
            //element - [2],[2] : 0
            //Expected Output:
            //The matrix is :
            //1 0 -1
            //0 0 1
            //-1 -1 0

        public void Determinantofmatrix()
        {
            Console.WriteLine("enter no. of rows of a matrix");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no. of cloumns of a matrix");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("enter values for matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Enter element at position ({i + 1}, {j + 1}): ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int determinant = 0;
            determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                           matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                           matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            Console.WriteLine("determinat of matrix is " + determinant);

        }

            //        Write a C# Sharp program that takes an array of integers and finds the smallest positive integer that is not present in that array.
            //Sample Data:
            //({ 1,2,3,5,6,7}) -> 4
            //({-1, -2, 0, 1, 3, 4, 5, 6}) -> 2

        public void SmallestInteger()
        {
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter elements");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
                var positiveNumbers = array.Where(x => x > 0).Distinct().OrderBy(x => x).ToList();
                int smallestPositive = 1;
                foreach (var num in positiveNumbers)
                {
                    if (num == smallestPositive)
                    {
                        smallestPositive++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(" samallest positive integer is :"+smallestPositive);

            

        }
    }

}
