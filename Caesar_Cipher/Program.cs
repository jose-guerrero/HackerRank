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
                if ((int)(n+k)>(int)'z')
                {
                    res.Add((char)(n+k-(int)'z'+(int)'a'-1));
                }
                else
                {
                    res.Add((char)(n+k));
                }
            }
            else
            {
                if (char.IsUpper(s[i]))
                {
                    int n = (int)s[i];
                    if ((int)(n+k)>(int)'Z')
                    {
                        res.Add((char)(n+k-(int)'Z'+(int)'A'-1));
                    }
                    else
                    {
                        res.Add((char)(n+k));
                    }

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

