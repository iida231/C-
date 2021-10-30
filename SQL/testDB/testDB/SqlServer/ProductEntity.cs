using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDB.SqlServer
{
    public sealed class ProductEntity
    {
        public ProductEntity(
            int productId,
            string productName,
            int price)
        {
        ProductId= productId;
        ProductName=productName;
            Price = price;


        }

        public int ProductId { get;}
        public string ProductName { get; }

        public int Price { get; }
    }
}
