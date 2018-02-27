using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int marsExploration(string s) {

        string temp = "SOS";
        int res = 0;

        for ( int i = 0; i < s.Length; i++)
            if (s[i]!=temp[i%3]) res++;
        
        return res;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int result = marsExploration(s);
        Console.WriteLine(result);
    }
}

