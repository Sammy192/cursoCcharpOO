using System;
using System.Collections.Generic;
using System.Text;

namespace ExerHeranca.Entities {
    class Account {
        public int Number { get; private set; }
        public String Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //saque
        public void Withdraw(double amount) {
            Balance -= amount;
        }

        //deposito
        public void Deposit(double amount) {
            Balance += amount;
        }


    }
}
