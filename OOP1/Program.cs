using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PascalCase    //CamelCase
            ProductManager productManager = new ProductManager();

            Product product = new Product();
            int sonuc = productManager.Topla(1 ,2);
            Console.WriteLine(sonuc);
        }
    }
}
