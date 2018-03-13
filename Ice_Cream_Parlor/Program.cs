using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
class Solution {

    static int[] icecreamParlor(int m, int[] arr) {
        int[]res = new int[2];
        
        for (int i=0;i<arr.Length;i++)
        {
            for (int j=i+1;j<arr.Length;j++)
            {
                int p = m - arr[i];
                if (p == arr[j])
                {
                    res[0] = i+1;
                    res[1] = j+1;
                   return res;
                }
            }
        }
        return res;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
            int[] result = icecreamParlor(m, arr);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}

