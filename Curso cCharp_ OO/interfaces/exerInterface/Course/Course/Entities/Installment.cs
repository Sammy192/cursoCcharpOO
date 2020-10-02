using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities {
    class Installment {
        public DateTime DueDate { get; set; }
        public Double Amount { get; set; }

        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
