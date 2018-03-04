using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

        int n = Convert.ToInt32(Console.ReadLine());
        Queue<int> q = new Queue<int>();

        while (n>0){
            n--;
            
            string[] tokens = Console.ReadLine().Split(' ');
            int[] h1 = Array.ConvertAll(tokens,Int32.Parse);

            if (h1[0]==1){
                q.Enqueue(h1[1]);
            }
            else{
                if (h1[0]==2)
                {
                    if (q.Count!=0 ) q.Dequeue();
                }
                else
                {
                    if (q.Count!=0)  Console.WriteLine(q.Peek());
                }
            }
        }
    
    }
}