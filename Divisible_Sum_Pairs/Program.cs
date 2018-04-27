using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int divisibleSumPairs(int n, int k, int[] arr) {
        int cont = 0;
        for (int i = 0;i<arr.Length-1;i++){
            for (int j=i+1;j<arr.Length;j++){
                int sum = arr[i]+arr[j];
                if (sum%k==0)
                    cont++;
            }
        }
        return cont;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}

