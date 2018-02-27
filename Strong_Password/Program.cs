using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int minimumNumber(int n, string password) {
        int cont = 0;

        foreach (char obj in "!@#$%^&*()-+")
            if (password.Contains(obj.ToString()))
            {
                cont++;
                break;
            }

        if (password.Any(char.IsDigit))
        {
            cont++;
        }
        if (password.Any(char.IsUpper))
        {
            cont++;
        }
        
        if (password.Any(char.IsLower))
        {
            cont++;
        }

        return 4 - cont + Math.Max(6-(n+4-cont),0);
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string password = Console.ReadLine();
        int answer = minimumNumber(n, password);
        Console.WriteLine(answer);
    }
}

