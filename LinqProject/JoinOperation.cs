using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class JoinOperation
    {
        public static void Do()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { ID=1, Name="Shirt", CatagoryID=1},
                new Product() { ID=2, Name="T-Shirt", CatagoryID=1},
                new Product() { ID=3, Name="Laptop", CatagoryID=2},
                new Product() { ID=4, Name="HeadPhones", CatagoryID=2},
                new Product() { ID=5, Name="Rice", CatagoryID=3},
                new Product() { ID=6, Name="Wheat", CatagoryID=3}
            };
            List<Catagory> catagories = new List<Catagory>()
            {
                new Catagory() { ID=1, CategoryName="Clothing"},
                new Catagory() { ID=2, CategoryName="Electronics"},
                new Catagory() { ID=3, CategoryName="FoodItems"},
            };

            /*var result = products.Join(
                catagories,
                product => product.CatagoryID,
                catagory => catagory.ID,
                (product,catagory) =>
                {
                    ProductID = product.ID,
                    Name = product.Name,
                    CategoryName = catagory.Name
                });*/
            var result = from product in products
                         join category in catagories
                         on product.CatagoryID equals category.ID
                         select new { product.ID, product.Name, category.CategoryName };
            foreach(var product in result)
            {
                Console.WriteLine($"{product.ID} | {product.Name} | {product.CategoryName}");
            }
        }
    }
    class Product
    {
        public long ID { get; set; }
        public String Name { get; set; }
        public long CatagoryID { get; set; }
    }
    class Catagory
    {
        public long ID { get; set; }
        public String CategoryName { get; set; }
    }
}
