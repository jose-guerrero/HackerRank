using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Edge(){
    int num;
    int dist;

    edge(num,dist)
    {
        num = num;
        dist = dist;
    }
}

class Solution {

    static int[] bfs(int n, int m, int[][] edges, int s) {
        int[] dist = new int[1005]();

        for (int i = 0; i<dist.Length; i++)
            dist[i] = -1;

        Queue<edge>q = new Queue<edge>();
        q.Enqueue(new edge(s,0));

        while(q.Count()!=0)
        {
            int num = q.Peek().num;
            int res = q.Peek().dist;
            
            q.pop();
            
            if (dist[num]!=-1) continue;

            dist[num] = res;

            for ()

        }
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            int[][] edges = new int[m][];
            for(int edges_i = 0; edges_i < m; edges_i++){
               string[] edges_temp = Console.ReadLine().Split(' ');
               edges[edges_i] = Array.ConvertAll(edges_temp,Int32.Parse);
            }
            int s = Convert.ToInt32(Console.ReadLine());
            int[] result = bfs(n, m, edges, s);
            Console.WriteLine(String.Join(" ", result));


        }
    }
}

