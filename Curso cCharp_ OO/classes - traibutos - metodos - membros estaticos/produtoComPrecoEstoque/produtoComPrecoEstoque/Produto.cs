using System;
using System.Globalization;

namespace produtoComPrecoEstoque {
    class Produto {

        private string _nome;
        public double Preco { get;  private set; }
        public int QuantidadeProdutoEstoqueAtual { get; private set; }
        
        //private double _preco;
        //private int _quantidadeProdutoEstoqueAtual;

        public Produto() {

        }

        public Produto(string nome, double preco, int quantidadeProdutoEstoqueAtual) {
            _nome = nome;
            Preco = preco;
            QuantidadeProdutoEstoqueAtual = quantidadeProdutoEstoqueAtual;
        }

        //definindo properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

       


        /* // geters and seters caso queira
        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

         public void SetPreco(double preco) {
             _preco = preco;
         

        public int GetQuantidadeProdutoEstoqueAtual() {
            return _quantidadeProdutoEstoqueAtual;
        }

        /* public void SetQuantidadeProdutoEstoqueAtual(int quantidadeProdutoEstoqueAtual) {
             _quantidadeProdutoEstoqueAtual = quantidadeProdutoEstoqueAtual;
         }*/



        public double ValorTotalEmEstoque() {
            return Preco * QuantidadeProdutoEstoqueAtual;
        }

        public void AdicionarProdutos(int quantidade) {
            QuantidadeProdutoEstoqueAtual = QuantidadeProdutoEstoqueAtual + quantidade;
            //QuantidadeProdutoEstoqueAtual += quantidadeAdicionar;
        }

        public void RemoverProdutos(int quantidade) {
            QuantidadeProdutoEstoqueAtual = QuantidadeProdutoEstoqueAtual - quantidade;
            //QuantidadeProdutoEstoqueAtual -= quantidadeAdicionar;
        }






        public override string ToString() {
            /* //maneira concatenada
             * return Nome
                + ", $ "
                + Preco.ToString("F2",CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture); */

            //interpolacao de dados

            return ($"Produto: {_nome} - Preco: $ {Preco.ToString("F2", CultureInfo.InvariantCulture)} - " +
                $"Qtd em estoque: {QuantidadeProdutoEstoqueAtual} unidades - " +
                $" Total: $ {ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)} ");

        }


    }
}
