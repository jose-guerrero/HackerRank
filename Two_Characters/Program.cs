using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    public static string RemoveDuplicates(string input)
    {
        return new string(input.ToCharArray().Distinct().ToArray());
    }

    public static int ValidateString(string input)
    {
        string temp = RemoveDuplicates(input);
        if (RemoveDuplicates(input).Length == 2)
        {
            if (input[0] == input [1]) return -1;

            for (int i = 2; i < input.Length; i+=2)
            {
                if (input[i] != input[0])
                    return -1;
            }

            for (int i = 3; i < input.Length; i+=2)
            {
                if (input[i] != input[1])
                    return -1;
            }

            return input.Length;
        }
        else
        {
            return -1;
        }
    }

    static int twoCharaters(string s) {

        if (ValidateString(s) != -1)
        {
            return s.Length;

        }

        string t = RemoveDuplicates(s);
        int result = -1;
        foreach (char value in t)
        {
            string temp = "";
            foreach (char key in s)
            {
                if (key!=value)
                {
                    temp += key;
                }
            }
            Console.WriteLine(temp);
            result = Math.Max(result,ValidateString(temp));
        }
        return result;
    }

    static void Main(String[] args) {
        int l = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = twoCharaters(s);
        Console.WriteLine(result);
    }
}

