using System;

namespace alistirme_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kisa kenar: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("uzun kenar: ");
            int b = int.Parse(Console.ReadLine());
            int alan = a*b;
            int cevre = 2*a+2*b;
            Console.WriteLine("Alan: " + alan);
            Console.WriteLine("cevre: " + cevre);
        }
    }
}