using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotaion
{
    // the reversal algorithm
    public class Method4
    {
        // reverse A to get Ar [2,1,3,4,5,6,7]
        // reverse B to get ArBr [2,1,7,6,5,4,3]
        // reverse all to get (ArBr)r = BA [3,4,5,6,7,1,2]
        public void leftRotate(int []arr, int d)
        {
            int n = arr.Length;
            reverseArray(arr, 0, d - 1);
            reverseArray(arr, d, n - 1);
            reverseArray(arr, 0, n - 1);
        }

        public void reverseArray(int []arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
