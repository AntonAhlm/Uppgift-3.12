using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många datorer äger du? : ");
            int datorer = Convert.ToInt32(Console.ReadLine());

            if (datorer == 1)
                Console.WriteLine("Du har 1 dator.");

            else if (datorer > 1)
                Console.WriteLine("Du har " + datorer + " datorer.");

            else if (datorer <= 0)
                Console.WriteLine(" :( ");
               


        }
    }
}
