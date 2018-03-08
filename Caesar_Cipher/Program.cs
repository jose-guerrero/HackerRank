using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string caesarCipher(string s, int k) {

        List<char>res = new List<char>();

        for (int i = 0;i < s.Length; i++)
        {
            if (char.IsLower(s[i]))
            {
                int n = (int)s[i];
                res.Add((char)(((n+k)-'a')%26 +'a'));
            }
            else
            {
                if (char.IsUpper(s[i]))
                {
                    int n = (int)s[i];
                    res.Add((char)(((n+k)-'A')%26 +'A'));
                }
                else
                {
                   res.Add(s[i]); 
                }
            }
        }

        string resp= string.Join("", res.ToArray());
        return resp;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        string result = caesarCipher(s, k);
        Console.WriteLine(result);
    }
}

