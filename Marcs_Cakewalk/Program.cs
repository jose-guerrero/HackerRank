using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long marcsCakewalk(int[] calorie) {

        Array.Sort(calorie);
        long sum = 0;
        for (int i = 0; i<calorie.Length;i++)
        {
            sum += (long)(calorie[calorie.Length-1-i]*Math.Pow(2,i));
        }
        return sum;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] calorie_temp = Console.ReadLine().Split(' ');
        int[] calorie = Array.ConvertAll(calorie_temp,Int32.Parse);
        long result = marcsCakewalk(calorie);
        Console.WriteLine(result);
    }
}

