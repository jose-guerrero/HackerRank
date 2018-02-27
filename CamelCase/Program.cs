using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int camelcase(string s) {
        int cont = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]-'a'<0)
            {
                cont++;
            }
        }
        return cont + 1;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int result = camelcase(s);
        Console.WriteLine(result);
    }
}

