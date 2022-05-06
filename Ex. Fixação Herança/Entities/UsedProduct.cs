using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._Fixação_Herança.Entities
{
    class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }


        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }


        public override string PriceTag()
        {
            string MD = ManufactureDate.ToShortDateString();
            return Name + " (usado) - R$" + Price.ToString("F2") + " (Data de fabricação: " + MD + " )";
        }

    }
}
