using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{       //Snippet
    class Product
    {
        public int ID { get; set; }
        public int CatagoryId { get; set; }
        public string ProductName { get; set; }//Ürün ismi
        public double UnitPrice { get; set; }//Birim Fiyatı
        public int UnitInStock { get; set; }//Stok durumu
    }
}
