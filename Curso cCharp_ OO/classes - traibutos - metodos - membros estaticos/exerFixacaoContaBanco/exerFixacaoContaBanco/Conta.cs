using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exerFixacaoContaBanco {
    class Conta {

        public static double ValorTaxaSaque = 5.0;

        public int NumeroConta { get; private set; }
        private string _titularConta;        
        public double SaldoConta { get; private set; }

        /*
        public Conta() {
        } */        

        public Conta(int numeroConta, string titularConta) {
            NumeroConta = numeroConta;
            _titularConta = titularConta;            
        }

        public Conta(int numeroConta, string titularConta, double valorInicial) :this (numeroConta, titularConta) {
            DepositarValor(valorInicial);
        }



        public void DepositarValor (double valor) {
             SaldoConta += valor;
        }

        public void RetirarValor (double valor) {
             SaldoConta -= valor + ValorTaxaSaque;
        }

        public string TitularConta {
            get { return _titularConta; }
            set {
                if (value != null && value.Length > 5) {
                    _titularConta = value;
                }
            }
        }

        public override string ToString() {
            return $"Conta {NumeroConta}, Titular: {_titularConta}, Saldo: $ {SaldoConta.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
