using System;
using System.Collections;

namespace Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Hashtable hashtable = new Hashtable();
            for (int i=1;i<=n;i++){
                string s = Console.ReadLine();
                string[] input = s.Split(' ');
                hashtable.Add(input[0],input[1]);

            }

            for (int i=1;i<=n;i++){
                string q = Console.ReadLine();
                string value = hashtable[q] as string;
                if (value==null) Console.WriteLine("Not found");
                else Console.WriteLine("{0}={1}",q,value);
            }
        }
    }
}
