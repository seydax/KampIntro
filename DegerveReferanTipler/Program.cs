using System;

namespace DegerveReferanTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int s1 = 10;
            int s2 = 20;
            s1 = s2;
            s2 = 65;
            Console.WriteLine("sayı1: "+s1);//20

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine("sayılar dizisi ilk: "+sayilar1[0]);//100

        }
    }
}
