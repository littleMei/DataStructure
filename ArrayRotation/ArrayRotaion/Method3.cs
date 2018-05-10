using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotaion
{
    // A Juggling Algorithm
    public class Method3
    {
        // time complexity O(n*d)
        // auxiliary space: O(1)
        public void leftRotate(int []arr, int d, int n)
        {
            int i, j, k, temp;
            for (i = 0; i < gcd(d, n); i++)
            {
                // move i-th values of blocks
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k -= n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }

        // function to get gcd of a and b
        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }
    }
}
