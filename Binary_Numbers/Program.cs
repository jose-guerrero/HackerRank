using System;

namespace Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0,ans = 0;
            
            int n = Convert.ToInt32(Console.ReadLine());

            while (n>0)
            {
                int m = n%2;
                n = n/2;

                if (m==1)
                {
                    temp++;
                }
                else
                {
                    temp = 0;
                    ans = Math.Max(ans,temp);
                }
            }
            ans = Math.Max(ans,temp);
            Console.WriteLine(ans);
        }
    }
}
