using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution {

    static void Main(String[] args) {
        string[] tokens_n1 = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(tokens_n1[0]);
        int n2 = Convert.ToInt32(tokens_n1[1]);
        int n3 = Convert.ToInt32(tokens_n1[2]);
        
        string[] h1_temp = Console.ReadLine().Split(' ');
        int[] h1 = Array.ConvertAll(h1_temp,Int32.Parse);
        List <string> s1 = new List <string>();
        List <string> s2 = new List <string>();
        List <string> s3 = new List <string>();
        long sum = 0;
        
        for (int i = n1-1; i>=0; i--)
        {
            sum += h1[i];
            s1.Add(sum.ToString());
        }

        string[] h2_temp = Console.ReadLine().Split(' ');
        int[] h2 = Array.ConvertAll(h2_temp,Int32.Parse);
        sum = 0;
        
        for (int i = n2-1; i>=0; i--)
        {
            sum += h2[i];
            s2.Add(sum.ToString());
        }

        string[] h3_temp = Console.ReadLine().Split(' ');
        int[] h3 = Array.ConvertAll(h3_temp,Int32.Parse);
        sum = 0;
        
        for (int i = n3-1; i>=0; i--)
        {
            sum += h3[i];
            s3.Add(sum.ToString());
        }

        string res = "0";
        for (int i=0;i<n1;i++)
        {
            if (s2.IndexOf(s1[i])!=-1 && s3.IndexOf(s1[i])!=-1) {res = s1[i];break;}
        }
        Console.WriteLine(res);
    }

}


