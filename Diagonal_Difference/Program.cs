using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int diagonalDifference(int[][] a) {
        int sum1 = 0,sum2 =0;

        for (int i=0;i<a.Length;i++)
        {
            sum1 += a[i][i];
            sum2 += a[i][a.Length-i-1];
        }
        
        return Math.Abs(sum1-sum2);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int result = diagonalDifference(a);
        Console.WriteLine(result);
    }
}

