using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int op,golInter,golGremio,vitoriaInter,vitoriaGremio,qntosGrenais,empate;
            string[] vet;
            /*string[] vet = Console.ReadLine().Split(' ');
            golInter = int.Parse(vet[0]);
            golGremio = int.Parse(vet[1]);

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            op = int.Parse(Console.ReadLine());*/

            op = 1;
            vitoriaGremio = 0;
            vitoriaInter = 0;
            empate = 0;
            qntosGrenais = 0;
            while (op == 1)
            {

                vet = Console.ReadLine().Split(' ');
                golInter = int.Parse(vet[0]);
                golGremio = int.Parse(vet[1]);

                if (golInter > golGremio){
                    vitoriaInter = vitoriaInter + 1;
                }else if (golGremio > golInter){
                    vitoriaGremio = vitoriaGremio + 1;                
                }else
                {
                    empate = empate + 1;
                }

                qntosGrenais = qntosGrenais +1;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                op = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(qntosGrenais + " grenais");
            Console.WriteLine("Inter:"+vitoriaInter);
            Console.WriteLine("Gremio:" + vitoriaGremio);
            Console.WriteLine("Empates:" + empate);

            if (vitoriaGremio > vitoriaInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (vitoriaInter > vitoriaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

            Console.ReadLine();
        }
    }
}
