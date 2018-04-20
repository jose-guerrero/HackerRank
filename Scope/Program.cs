using System;
using System.Linq;

namespace Scope
{
    class Difference {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a){
            elements = a;
        }

        public void computeDifference(){
            int mini = 200;
            int maxi = -1;
        
            for (int i =0;i<elements.Length;i++)
            {
                maxi = Math.Max(maxi,elements[i]);
                mini = Math.Min(mini,elements[i]);
            }

            maximumDifference = maxi - mini;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());
        
            int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
            Difference d = new Difference(a);
        
            d.computeDifference();
        
            Console.Write(d.maximumDifference);
        }
    }
}
