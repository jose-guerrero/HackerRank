using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int powerSum(int X, int N,int num) {
        
        if (X<0) return 0;
        if (X==0) return 1;
        int mult = 1;
        for (int i=1;i<=N;i++) mult*=num;
        if (X<mult) return 0;
        return powerSum(X,N,num+1)+powerSum(X-mult,N,num+1);
    }

    static void Main(String[] args) {
        int X = Convert.ToInt32(Console.ReadLine());
        int N = Convert.ToInt32(Console.ReadLine());
        int result = powerSum(X, N,1);
        Console.WriteLine(result);
    }
}