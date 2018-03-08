using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {

        string s = Console.ReadLine();
        bool[] taken = new bool[26];
        int res = 0;


        for (int i=0;i<s.Length;i++)
        {
            if (Char.IsLower(s[i]) && taken[s[i]-'a']!=true)
            {
                taken[s[i]-'a'] = true;
                res++;
            }
            else
            {
                if (Char.IsUpper(s[i]) && taken[s[i]-'A']!=true)
                {
                    taken[s[i]-'A'] = true;
                    res++;
                }
            }
        }

        if (res == 26)
        {
            Console.WriteLine("pangram");
        }
        else
        {
            Console.WriteLine("not pangram");
        }
    
    }
}
}

