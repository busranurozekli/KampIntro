using System;
using System.Collections.Generic;
using System.Text;

namespace OOP12

    //snippet
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //hangi kategoriye dahil
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
