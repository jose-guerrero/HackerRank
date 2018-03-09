using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string funnyString(string s){
       
        for (int i=0;i<s.Length-1;i++)
        {
            if (Math.Abs((int)s[i+1]-(int)s[i]) != Math.Abs((int)s[s.Length-i-2] - (int)s[s.Length-1-i]))
            {
                return "Not Funny";
            }
        }

        return "Funny";

    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string result = funnyString(s);
            Console.WriteLine(result);
        }
    }
}

