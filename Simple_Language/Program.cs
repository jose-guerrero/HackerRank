using System;

namespace Simple_Language
{
    class Program
    {

        static long maximumProgramValue(int n) {

            long res = 0;

            for (int i=0;i<n;i++)
            {
                string s = Console.ReadLine();
                string[] Split = s.Split();
                long num = Convert.ToInt64(Split[1]);

                if (Split[0]=="add")
                {
                    if (num < 0) continue;
                    res+=num;
                }
                else
                {
                    res = Math.Max(num,res);
                }
            }

            return res;
        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            long result = maximumProgramValue(n);

            Console.WriteLine(result);
        }
    }
}
