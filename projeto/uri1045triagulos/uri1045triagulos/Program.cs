using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace uri1045triagulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3,a,b,c;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1],CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2],CultureInfo.InvariantCulture);
            a = 0;
            b = 0;
            c = 0;


            if ((n1 >= n2) && (n1 >= n3) && (n2 >= n3) )
            {
                //escreval("A ordem crescente é: n3,n2,n1: ", n3, " -", n2, " -", n1)
                //Console.WriteLine(n3);
                //Console.WriteLine(n2);
               // Console.WriteLine(n1);
                a = n1;
                b = n2;
                c = n3;
            }
            else if ((n1 >= n3) && (n1 >= n2) && (n3 >= n2) )
            {
                //escreval("A ordem crescente é: n2,n3,n1: ", n2, " -", n3, " -", n1)
                //Console.WriteLine(n2);
               // Console.WriteLine(n3);
               // Console.WriteLine(n1);
                a = n1;
                b = n3;
                c = n2;
            }
            else if ((n2 >= n3) && (n2 >= n1) && (n3 >= n1))
            {

                //escreval("A ordem crescente é: n1,n3,n2: ", n1, " -", n3, " -", n2)
               // Console.WriteLine(n1);
               // Console.WriteLine(n3);
               // Console.WriteLine(n2);
                a = n2;
                b = n3;
                c = n1;
            }
            else if ((n2 >= n1) && (n2 >= n3) && (n1 >= n3) )
            {

                //escreval("A ordem crescente é: n3,n1,n2: ", n3, " -", n1, " -", n2)
               // Console.WriteLine(n3);
               // Console.WriteLine(n1);
                //Console.WriteLine(n2);
                a = n2;
                b = n1;
                c = n3;
            }
            else if ((n3 >= n1) && (n3 >= n2) && (n1 >= n2))
            {

                //escreval("A ordem crescente é: n2,n1,n3: ", n2, " -", n1, " -", n3)
               // Console.WriteLine(n2);
               // Console.WriteLine(n1);
               // Console.WriteLine(n3);
                a = n3;
                b = n1;
                c = n2;
            }
            else if ((n3 >= n2) && (n3 >= n1) && (n2 >= n1))
            {
                //escreval("A ordem crescente é: n1,n2,n3: ", n1, " -", n2, " -", n3)
               // Console.WriteLine(n1);
               // Console.WriteLine(n2);
               // Console.WriteLine(n3);
                a = n3;
                b = n2;
                c = n1;
            }
           // Console.WriteLine();
           // Console.WriteLine("-------------------------------------");

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }else if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");

            }else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");

            }else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if ((a == b) & (b == c))
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }

            if ( ((a == b) & (b != c)) | ((a == c) & (c != b)) | ((b == c) & (c != a)))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }



                Console.ReadLine();

        }
    }
}
