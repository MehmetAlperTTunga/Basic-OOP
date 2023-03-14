using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace _3__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName= "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 10;

            Product product2 = new Product() {
                Id = 2,
                CategoryId = 5,
                ProductName = "Pen",
                UnitPrice = 35
            };

            ProductManager productManager= new ProductManager();
            string isim = "ALPER";
            productManager.Add(product2);

            List<string> isimler2 = new List<string> { "Jhon", "Elisa", "Boris", "Beth" };
            isimler2.Add(isim);
            Console.WriteLine(isimler2[4]);


            MyList<string> myList= new MyList<string>();
            myList.Add("Mehmet");

            Console.WriteLine(myList.Length);

            myList.Add("Alper");

            Console.WriteLine(myList.Length);

            Console.ReadLine();
        }
    }
}
