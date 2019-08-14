using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, mi, hf, mf, iniciom, fimm, duracao, dh, dm;



            String[] vet;

            vet = Console.ReadLine().Split(' ');

            hi = int.Parse(vet[0]);
            mi = int.Parse(vet[1]);
            hf = int.Parse(vet[2]);
            mf = int.Parse(vet[3]);

            iniciom = hi * 60 + mi;
            fimm = hf * 60 + mf;
            duracao = fimm - iniciom;



            if (iniciom == fimm)
            {
                duracao = 24 * 60;
            }
            else if (fimm > iniciom)
            {
                duracao = fimm - iniciom;
            }
            else if (fimm < iniciom)
            {
                duracao = (24 * 60 - iniciom) + fimm;
            }
            else { }
            dh = duracao / 60;
            dm = duracao % 60;
            Console.WriteLine("O JOGO DUROU " + dh + " HORA(S) E " + dm + " MINUTO(S)");
            Console.ReadLine();

        }
    }
   }



