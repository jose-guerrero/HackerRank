using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution {

    static string common_letters(string s1,string s2)
    {
        List<char>res = new List<char>();
        var common = s1.Intersect(s2);

        foreach (var c in common)
            res.Add(c);

        string resp= string.Join("", res.ToArray());

        return resp;
    }


    static int gemstones(string[] arr)
    {

        string s = common_letters(arr[0],arr[1]);
        for (int i=2;i<arr.Length;i++)
        {
            s = common_letters(s,arr[i]);
        }
        return s.Length;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for(int arr_i = 0; arr_i < n; arr_i++){
           arr[arr_i] = Console.ReadLine();   
        }
        int result = gemstones(arr);
        Console.WriteLine(result);
    }
}

