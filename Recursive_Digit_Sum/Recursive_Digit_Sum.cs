using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string SumStrings(string s1,char s2)
    {
        if (s1)
        return "";
    }

    static int digitSum(string n, int k) {
        // Complete this function
        string temp = "";
        for (int i = 0;i < k; i++)
            temp += n;

        while (true)
        {
            if (temp.Length == 1) break;
            string sum = "";
            for (int i=0;i<temp.Length;i++)
                sum = SumStrings(sum,temp[i]);
            temp = sum;
        }
        
        return 0;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        string n = tokens_n[0];
        int k = Convert.ToInt32(tokens_n[1]);
        int result = digitSum(n, k);
        Console.WriteLine(result);
    }
}