using System;

//   THIS PROGRAM IS CREATED BY:

//   XXXXx   XXXXx   XXXXXX  XXX
//   XX  XX  XX  XX  XX      XXX
//   XX  XX  XXXXx   XXXXX   XXX
//   XX  XX  XX  XX  XX      XXX
//   XXXXx   XX  XX  XXXXXX  XXX


namespace CodeByDrei

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 100)

            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Hello Goodbye");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Hello");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                }

                else
                {
                    Console.WriteLine(i);
                }

                i++;

            }

        }

    }

}