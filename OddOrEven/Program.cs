using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            IsOdd();
        }


        public static bool IsOdd()
        {
            int num;
            Console.WriteLine("Enter a number of your choice" );
              num = int.Parse(Console.ReadLine());

            if (num % 3 == 0)
            {

                Console.WriteLine("you got the right answer and you are so smart");
                return true;
            }

            else
            {

                Console.WriteLine("sorry, you got the wrong answer, try again!");
                return false;
            }
        }

    }
}
