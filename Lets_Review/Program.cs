using System;

namespace Lets_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i =1;i<=n;i++)
            {
                string temp = Console.ReadLine();
                string temp_even = "",temp_odd="";

                for (int j=0;j<temp.Length;j++){
                    if (j%2==1) temp_odd += temp[j];
                    else temp_even += temp[j];
                }
                Console.WriteLine("{0} {1}",temp_even,temp_odd);
            }
        }
    }
}
