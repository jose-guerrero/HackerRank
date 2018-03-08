using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string hackerrankInString(string s) {
        string temp = "hackerrank";
        int j = 0;
        for (int i=0;i<s.Length;i++)
        {
            if (s[i]==temp[j])
            {
                j++;
                if (j>=temp.Length) return "YES";
            }
        }
        return "NO";
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string result = hackerrankInString(s);
            Console.WriteLine(result);
        }
    }
}

