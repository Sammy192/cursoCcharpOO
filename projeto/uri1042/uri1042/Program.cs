using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

           if ((n1 > n2) && (n1 > n3) &&  (n2 > n3)) {                
                //escreval("A ordem crescente é: n3,n2,n1: ", n3, " -", n2, " -", n1)
                Console.WriteLine(n3);
                Console.WriteLine(n2);
                Console.WriteLine(n1);
           }else if ((n1 > n3) &&  (n1 > n2) && (n3 > n2)){
                //escreval("A ordem crescente é: n2,n3,n1: ", n2, " -", n3, " -", n1)
                Console.WriteLine(n2);
                Console.WriteLine(n3);
                Console.WriteLine(n1);

            }else if ((n2 > n3) && (n2 > n1) && (n3 > n1)){

                //escreval("A ordem crescente é: n1,n3,n2: ", n1, " -", n3, " -", n2)
                Console.WriteLine(n1);
                Console.WriteLine(n3);
                Console.WriteLine(n2);

            }else if ((n2 > n1) && (n2 > n3) && (n1 > n3)) {

                //escreval("A ordem crescente é: n3,n1,n2: ", n3, " -", n1, " -", n2)
                Console.WriteLine(n3);
                Console.WriteLine(n1);
                Console.WriteLine(n2);

            }else if ((n3 > n1) && (n3 > n2) && (n1 > n2)) {

                //escreval("A ordem crescente é: n2,n1,n3: ", n2, " -", n1, " -", n3)
                Console.WriteLine(n2);
                Console.WriteLine(n1);
                Console.WriteLine(n3);

            }else if ((n3 > n2) && (n3 > n1) && (n2 > n1)){
                //escreval("A ordem crescente é: n1,n2,n3: ", n1, " -", n2, " -", n3)
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(n3);
            }
            Console.WriteLine();
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            Console.ReadLine();


        }
    }
}
