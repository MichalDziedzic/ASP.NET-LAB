using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductModel> GetItems()
        {
            return new List<ProductModel>
            {
                new ProductModel {ProductName="Twilight Book",ProductDescription="It is history about two people...",ProductPrice=50},
                new ProductModel {ProductName="Harry Potter book",ProductDescription="It is history about wizard boy...",ProductPrice=80},
                new ProductModel {ProductName="True Blood book",ProductDescription="It is history about one vampire and half fairy...",ProductPrice=100},
                new ProductModel {ProductName="The vampires diaries Book",ProductDescription="It is history about two vampires and girl...",ProductPrice=60},
                new ProductModel {ProductName="The phantom of the opera Book",ProductDescription="It is history about one person who is ugly man...",ProductPrice=40}
            };
        }
    }
}
