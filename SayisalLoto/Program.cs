using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-49 arasında tekrar etmeyen 6 adet random sayı üretir

            Random rnd = new Random();
            int sayi;
            int[] sayisalLoto = new int[6];

            for (int i = 0; i < sayisalLoto.Length;)
            {
                sayi = rnd.Next(1, 50);

                if (!sayisalLoto.Contains(sayi))
                {
                    sayisalLoto[i] = sayi;
                    i++;
                }
            }

            Array.Sort(sayisalLoto);
            foreach (var k in sayisalLoto)
            {
                Console.Write(k + " ");
            }
            Console.ReadLine();
        }
    }
}
