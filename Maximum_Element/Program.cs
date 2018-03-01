using System;
using System.Collections.Generic;
using System.IO;


public class node{
    public long num;
    public long maxi;

    public node()
    {
        num = -1;
        maxi = -1;
    }

    public void assign(long num1,long maxi1)
    {
        num = num1;
        maxi = maxi1;
    }
}
class Solution {
    static void Main(String[] args) {
        
        int n = int.Parse(Console.ReadLine());
        long maximo = -1;
        Stack<node> stack = new Stack<node>();
        node nodo = new node();

        while (n>0)
        {
            n--;
            string[] tokens = Console.ReadLine().Split();
            int m = int.Parse(tokens[0]);

            if (m == 1)
            {
                long num = long.Parse(tokens[1]);
                if (maximo < num)  maximo = num;
                nodo.assign(num,maximo);
                stack.Push(nodo);
            }
            if (m == 2)
            {
                if (stack.Count!=0)
                {
                    stack.Pop();     
                    if (stack.Count == 0) maximo = -1;
                    else maximo = stack.Peek().maxi;
                }
            }
            if (m == 3)
            {
                if (stack.Count!=0)
                {
                    Console.WriteLine(stack.Peek().maxi);
                }
             
            }
        }

    }
}