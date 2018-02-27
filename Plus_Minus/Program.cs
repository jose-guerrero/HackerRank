using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void plusMinus(int[] arr) {
        
        int num1 = 0,num2 = 0,num3 = 0; 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]>0) num1++;
            else {
                if (arr[i]<0) num2++;
                else num3++;
            }
             
        }
        Console.WriteLine((num1*1.0/arr.Length).ToString("N6"));
        Console.WriteLine((num2*1.0/arr.Length).ToString("N6"));
        Console.WriteLine((num3*1.0/arr.Length).ToString("N6"));
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        plusMinus(arr);
    }
}

