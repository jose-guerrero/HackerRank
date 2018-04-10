using System;

namespace Class_vs_Instance
{

    public class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0");
            }
            else
            {
                age = initialAge;
            }
        }

        public void yearPasses()
        {
            age++;
        }

        public void amIOld()
        {
            if (age < 13)   Console.WriteLine("You are young.");
            else{
                if (age<18)     Console.WriteLine("You are a teenager.");
                else Console.WriteLine("You are old");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i=1;i<=n;i++){
                int m = Int32.Parse(Console.ReadLine());
                Person p = new Person(m);
                p.amIOld();
                p.yearPasses();
                p.yearPasses();
                p.yearPasses();
                p.yearPasses();
                p.amIOld();
            }
        }
    }
}
