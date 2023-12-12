using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class SearchingAndSorting
    {
        public void  Shellsort()
        {
            int[] array  = new int[] {3,6,5,4,8,9,28,7,9,3,90 };
            int n= array.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
          
        }

        public void bubblesort()
        {
            int[] arr = new int[] {23,67,233,45,67,4,2,1,7,0};
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }  
            
            foreach(var element in arr)
            {
                Console.Write(element + " ");
            }
        }
        public void CountingSort()
        {
            int[] arr = new int[] { 23, 67, 233, 45, 67, 4, 2, 1, 7, 0 };
            int max = arr.Max();
            int min = arr.Min();
            int range = max - min + 1;
            int[] count = new int[range];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }
            int[] output = new int[arr.Length];
            int outputIndex = 0;
            for (int i = 0; i < range; i++)
            {
                while (count[i] > 0)
                {
                    output[outputIndex++] = i + min;
                    count[i]--;
                }
            }
            Array.Copy(output, arr, arr.Length);
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
        }

        public void HeapSort()
        {
            int[] arr = new int[] { 23, 67,65,5, 67,84, 0,7, 7, 0 };
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
               
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

              
                Heapify(arr, i, 0);
            }

           
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }



        //       public void MergeSort()
        //       {
        //           int[] arr = new int[] { 5, 87, 998, 6, 9, 6, 0, 28, 5, 5 };
        //           int n = arr.Length;
        //           if (arr == null || arr.Length <= 1)
        //               return;
        //           int[] temp = new int[n];

        ////oid MergeSortHelper(int[] arr, int[] temp, int left, int right)
        //           {
        //               if (left < right)
        //               {
        //                   int mid = (left + right) / 2;

        //                   MergeSortHelper(arr, temp, left, mid);
        //                   MergeSortHelper(arr, temp, mid + 1, right);

        //                   Merge(arr, temp, left, mid, right);
        //               }
        //           }

        //          private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        //           {
        //               int i = left;
        //               int j = mid + 1;
        //               int k = left;

        //               while (i <= mid && j <= right)
        //               {
        //                   if (arr[i] <= arr[j])
        //                   {
        //                       temp[k] = arr[i];
        //                       i++;
        //                   }
        //                   else
        //                   {
        //                       temp[k] = arr[j];
        //                       j++;
        //                   }
        //                   k++;
        //               }

        //               while (i <= mid)
        //               {
        //                   temp[k] = arr[i];
        //                   i++;
        //                   k++;
        //               }

        //               while (j <= right)
        //               {
        //                   temp[k] = arr[j];
        //                   j++;
        //                   k++;
        //               }

        //               for (int p = left; p <= right; p++)
        //               {
        //                   arr[p] = temp[p];
        //               }
        //           }





    }
}
