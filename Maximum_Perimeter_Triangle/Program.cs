using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static bool IsTriangle(int c,int b,int a){

        if (a+b>c && a+c>b && b+c>a)
            return true;
        return false; 
    }

    // Complete the maximumPerimeterTriangle function below.
    static string maximumPerimeterTriangle(string[] s) {

        int[] temp = new int[s.Length];

        for (int i=0;i<s.Length;i++)
            temp[i] = Convert.ToInt32(s[i]);

        Array.Sort(temp);

        for (int i=temp.Length-1;i>=2;i--)
        {
            for (int j=i-1;j>=1;j--)
            {
                for (int k=j-1;k>=0;k--)
                {
                    if (IsTriangle(temp[i],temp[j],temp[k]))
                    {
                        string t = Convert.ToString(temp[k])+" "+Convert.ToString(temp[j])+" "+Convert.ToString(temp[i]);
                        return t;
                    }
                }

            }
        }

        return "-1";
    }

    static void Main(string[] args) {
        
        int n = Convert.ToInt32(Console.ReadLine());
        string[] temp = Console.ReadLine().Split(' ');
        string result = maximumPerimeterTriangle(temp);

        Console.WriteLine(result);
    }
}

