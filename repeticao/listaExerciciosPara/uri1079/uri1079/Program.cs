using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao, somaPeso;
            int peso1 = 2;
            int peso2 = 3;
            int peso3 = 5;
            double n1, n2, n3,media;
            n1 = 0.0;
            n2 = 0.0;
            n3 = 0.0;
            media = 0.0;

            repeticao = int.Parse(Console.ReadLine());
            somaPeso = (peso1 + peso2 + peso3);
            for (int i=0; i< repeticao; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                n1 = double.Parse(vet[0] , CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((n1 * peso1) + (n2 * peso2 ) + (n3 * peso3) ) / somaPeso;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }

            Console.ReadLine();

        }
    }
}
