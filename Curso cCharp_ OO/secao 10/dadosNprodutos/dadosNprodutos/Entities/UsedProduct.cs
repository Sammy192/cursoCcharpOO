using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace dadosNprodutos.Entities {
    class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufacureDate) :base(name,price) {
            ManufactureDate = manufacureDate;
        }

        public override string PriceTag() {
            return Name
            + " (Used) $"            
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " (Manufacture date: "
            + ManufactureDate.ToString("dd/MM/yyyy")
            + ")";
        }

    }
}
