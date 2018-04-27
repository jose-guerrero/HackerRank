using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int digitSum(string n, int k) {
        // Complete this function
        string temp = "";
        int res = 0;
        long sumi = 0;

        for (int i=0;i<n.Length;i++){
                sumi += n[i]-'0';
        }

        temp = Convert.ToString(sumi*k);

        while (true)
        {
            if (temp.Length == 1) break;
            long sum = 0;
            
            for (int i=0;i<temp.Length;i++){
                sum += temp[i]-'0';
            }
            temp = Convert.ToString(sum);
        }

        res = temp[0] - '0';
        
        return res;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        string n = tokens_n[0];
        int k = Convert.ToInt32(tokens_n[1]);
        int result = digitSum(n, k);
        Console.WriteLine(result);
    }
}