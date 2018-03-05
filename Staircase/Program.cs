using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void staircase(int n) {
        for (int i=0;i<n;i++)
        {
            string s = "";
            for (int j=0;j<=n-i-2;j++){
                s+=" ";
            }
            for (int j=n-i-1;j<n;j++){
                s+="#";
            }
            Console.WriteLine(s);
        }
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
