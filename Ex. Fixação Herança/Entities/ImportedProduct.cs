using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._Fixação_Herança.Entities
{
    class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice(double price, double customsfee )
        {
            return Price = price + customsfee;
        }

        public override string PriceTag()
        {
            TotalPrice(Price, CustomsFee);
            return Name + " - R$" + Price.ToString("F2") + " (Taxa da Alfândega: R$" + CustomsFee.ToString("F2") + ")";
        }

    }
}
