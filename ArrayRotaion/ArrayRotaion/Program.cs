using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotaion
{
    // Write a function rotate(arr[], d, n) that rotates arr[] of size n by d elements from the beginning.
    class Program
    {
        // method 1 using temp array

        // method 2 rotate one by one
        static void leftRotate(int []arr, int d, int n)
        {
            for (int i = 0; i < d; i++)
                leftRotatebyOne(arr, n);
        }

        static void leftRotatebyOne(int []arr, int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];    // 把所有item都向左移一个

            arr[i] = temp;   //把第一个放到最后 
        }

        // utility function to print an array 
        static void printArray(int []arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Array before rotate:");
            printArray(arr, 7);
        
            leftRotate(arr, 2, 7);
            Console.WriteLine("Array after rotate:");
            printArray(arr, 7);

            Console.ReadLine();
        }
    }
}
