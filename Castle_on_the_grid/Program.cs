using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class node{
    public int x;
    public int y;
    public int steps;

    public node(){
        x = 0;
        y = 0;
        steps = 0;
    }

    public void assign(int a,int b,int c){
        x = a;
        y = b;
        steps = c;
    }
}

class Solution {

    static int minimumMoves(List<string>s,int n, int startX, int startY, int goalX, int goalY) {

        string[,] graph = new string[n,n];
        bool[,] known = new bool [n,n];
        node nodo = new node();
        int res=0;
        int i,j;

        for ( i=0;i<n;i++){
            for ( j=0;j<n;j++)
            {
                known[i,j]= false;
                graph[i,j] = s[i][j].ToString();
            }
        }

        Queue<node>q = new Queue<node>();

        nodo.assign(startX,startY,0);
        q.Enqueue(nodo);

        while (q.Count!=0)
        {
            nodo = q.Peek();
            q.Dequeue();
            if (known[nodo.x,nodo.y]== true) continue;
            known[nodo.x,nodo.y] = true;
            if (nodo.x == goalX && nodo.y == goalY)
            {
                res = nodo.steps;
                break;
            }

            for (i=nodo.x+1;i<n;i++)
            {
                if (graph[i,nodo.y]=="X") break;
                if (known[i,nodo.y] == true) continue;
                node temp = new node();
                temp.assign(i,nodo.y,nodo.steps+1);
                q.Enqueue(temp);
            }

            for (i=nodo.x-1;i>=0;i--)
            {
                if (graph[i,nodo.y]=="X") break;
                if (known[i,nodo.y] == true) continue;
                node temp = new node();
                temp.assign(i,nodo.y,nodo.steps+1);
                q.Enqueue(temp);
            }

            for (j=nodo.y+1;j<n;j++)
            {
                if (graph[nodo.x,j]=="X") break;
                if (known[nodo.x,j] == true) continue;
                node temp = new node();
                temp.assign(nodo.x,j,nodo.steps+1);
                q.Enqueue(temp);
            }

            for (j=nodo.y-1;j>=0;j--)
            {
                if (graph[nodo.x,j]=="X") break;
                if (known[nodo.x,j] == true) continue;
                node temp = new node();
                temp.assign(nodo.x,j,nodo.steps+1);
                q.Enqueue(temp);
            }
        }

        return res;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<string>s = new List<string>();

        for (int i=0;i<n;i++)
        {
            string grid = Console.ReadLine();
            s.Add(grid);
        }

        string[] tokens_startX = Console.ReadLine().Split(' ');
        int startX = Convert.ToInt32(tokens_startX[0]);
        int startY = Convert.ToInt32(tokens_startX[1]);
        int goalX = Convert.ToInt32(tokens_startX[2]);
        int goalY = Convert.ToInt32(tokens_startX[3]);
        int result = minimumMoves(s,n, startX, startY, goalX, goalY);
        Console.WriteLine(result);
        
    }
}

