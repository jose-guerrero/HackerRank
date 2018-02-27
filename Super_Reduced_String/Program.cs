using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s){

        List<Char> temp = new List<Char>();
        int i = 0, j;

        while (i < s.Length)
        {
            for (j = i + 1; j < s.Length ; j++)
            {
                if (s[j]!=s[i])
                {
                    break;
                }
            }
            if ((j-i)%2==1)
                temp.Add(s[i]);

            i = j;
        }
        string t = string.Join("", temp.ToArray());
        if (t.Length == 0)
        {
            return "Empty String";
        }
        else
        {
            if (s == t)
                return t;
            else
                return super_reduced_string(t);
        }
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}

