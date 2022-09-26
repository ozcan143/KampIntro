using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {
        public void Add(product product)
        {
            Console.WriteLine(product.ProductName + "eklendi") ;

        }

        public void Update (product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }

    }
}
