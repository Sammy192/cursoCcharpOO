using System;
using System.Globalization;

namespace exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] nome = new string[num];
            double[] precoCompra = new double[num];
            double[] precoVenda = new double[num];

            for (int i=0; i <num; i++)
            {
                string[] entradaDados = Console.ReadLine().Split(' ');
                nome[i] = entradaDados[0];
                precoCompra[i] = double.Parse(entradaDados[1],CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(entradaDados[2],CultureInfo.InvariantCulture);
            }

            // 1: vamos encontrar a quantidade para cada faixa de lucro desejada
            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;
            for (int i = 0; i < num; i++)
            {

                double lucro = precoVenda[i] - precoCompra[i];

                double porcentagemDeLucro = lucro / precoCompra[i] * 100.0;

                if (porcentagemDeLucro < 10.0)
                {
                    contAbaixoDe10++;
                }
                else if (porcentagemDeLucro <= 20.0)
                {
                    contEntre10E20++;
                }
                else
                {
                    contAcimaDe20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            // 2: vamos achar os totais
            double totalCompra = 0.0;
            double totalVenda = 0.0;
            for (int i = 0; i < num; i++)
            {
                totalCompra = totalCompra + precoCompra[i];
                totalVenda = totalVenda + precoVenda[i];
            }

            double totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
