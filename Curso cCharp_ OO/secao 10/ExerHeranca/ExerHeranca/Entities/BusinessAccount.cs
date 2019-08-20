using System;
using System.Collections.Generic;
using System.Text;

namespace ExerHeranca.Entities {
    class BusinessAccount : Account {
        public double LoanLimit { get; set; }

        public BusinessAccount() {
        }

        public BusinessAccount(int number, string holder, double balance,double loanLimit) : base(number,holder,balance) {
            LoanLimit = loanLimit;
        }

        //operacao de emprestimo

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }


    }
}

