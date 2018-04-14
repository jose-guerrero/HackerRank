using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int[] dest = new int[1000005];
    
    static int downToZero(int n) {

        int res,m;

        if (dest[n]!=0) return dest[n];
        if (n<=0) return 0;
        if (n==1) return 1;
        if (n==2) return 2;

        res = 1 + downToZero(n-1);

        int max_int = (int)Math.Sqrt(n);

        if (max_int*max_int < n) max_int++;

        for (int i=2;i<=max_int;i++)
        {
            if (n%i==0)
            {
                m = n/i;
                res = Math.Min(1+downToZero(Math.Max(m,i)),res);
            }
        }

        dest[n]=res;
        return dest[n]; 
    }

    static void Main(string[] args) {
        /* 
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = downToZero(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();*/

        
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = downToZero(n);

            Console.WriteLine(result);
        }

    }
}

