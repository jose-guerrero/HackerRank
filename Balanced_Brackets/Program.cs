using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static bool isBalanced(string s) {

        Stack <char> container = new Stack <char> ();

        for (int i = 0; i < s.Length ; i++)
        {
            if (s[i]=='{' || s[i]=='(' || s[i]=='[')
            {
                container.Push(s[i]);
            }
            else
            {
                if (s[i]=='}')
                {
                    if (container.Count!=0)
                    {
                        if (container.Peek()=='{')
                        {
                            container.Pop();
                            continue;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                
                if (s[i]==')')
                {
                    if (container.Count!=0)
                    {
                        if (container.Peek()=='(')
                        {
                            container.Pop();
                            continue;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                if (s[i]==']')
                {
                    if (container.Count!=0)
                    {
                        if (container.Peek()=='[')
                        {
                            container.Pop();
                            continue;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        if (container.Count==0) return true;
        else return false;
    }

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string s = Console.ReadLine();
            if (isBalanced(s)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}