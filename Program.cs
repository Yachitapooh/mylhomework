using System;

namespace myhomework_6_2
{
    class Program
    {
        static void Main(string[] args) 
        {
            int ddd, yyy;
            Console.Write("Input your birthday : ");
            ddd = int.Parse(Console.ReadLine());
            Console.Write("Input your year of birth : ");
            yyy = int.Parse(Console.ReadLine());

            string mmm;
            Console.Write("Input your mount of birth : ");
            mmm = Console.ReadLine();

            int year = 2564;
            Console.WriteLine("Your age is : {0} years old",year - yyy);
            int age;
            Console.Write("Input your age : ");
            age = int.Parse(Console.ReadLine());

            while (year == age)
            {
                if (year == age)
                {
                    if (year >= 18)
                    {
                        Console.WriteLine("You can sign up.");
                        string name, surname;
                        Console.Write("Input your name : ");
                        name = Console.ReadLine();
                        Console.Write("Input your surnsme : ");
                        surname = Console.ReadLine();
                        Console.WriteLine("Ready to use");
                    }
                    else
                    {
                        Console.Write("Under age cannot apply for sign up.");
                    }
                }
                else { }
            }

            Console.ReadLine();

        }
    }
}
