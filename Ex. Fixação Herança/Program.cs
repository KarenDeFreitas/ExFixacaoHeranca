using System;
using Ex._Fixação_Herança.Entities;
using System.Collections.Generic;

namespace Ex._Fixação_Herança
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();


            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Dados do produto #" + i);
                Console.Write("O produto é comum, usado ou importado? ");
                string tipo = Console.ReadLine();
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: R$");
                double price = double.Parse(Console.ReadLine());


                if (tipo == "usado")
                {
                    Console.Write("Data de fabricação: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }


                else if (tipo == "importado")
                {
                    Console.Write("Taxa da alfândega: R$");
                    double customsFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, customsFee));
                }


                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiquetas de preço: ");


            foreach(Product product in products)
            {
                
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
