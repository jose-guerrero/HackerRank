using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        int t = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1;i<=t;i++){
            int num = Convert.ToInt32(Console.ReadLine());
            
            int m = (int)Math.Sqrt(num);
            
            bool res = false;
   
            for (int j=2;j<=(m+1);j++)
            {
                if (num%j == 0){
                    res = true;
                    break;
                }
            }
            if (res == true || num==1) Console.WriteLine("Not prime");
            else Console.WriteLine("Prime");
        }
    }
}