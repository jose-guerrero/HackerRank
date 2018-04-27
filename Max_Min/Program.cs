using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int angryChildren(int k, int[] arr) {
        
        int res = -1;
        Array.Sort(arr);
        
        for (int i=0;i<arr.Length;i++){
            int j = i + k -1;
            if (j>=arr.Length) break;
            
            if (res == -1) res = arr[j] - arr[i];
            else
            {
                res = Math.Min(res,arr[j]-arr[i]);
            }
        }
        return res;    
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for(int arr_i = 0; arr_i < n; arr_i++){
           arr[arr_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int result = angryChildren(k, arr);
        Console.WriteLine(result);
    }
}