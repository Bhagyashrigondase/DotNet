using ClothingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClothingApp.Repositories
{
    public class ProductRepo : IProductRepo
    {
        public List<Product> GetAllProductRepo()
        {
            using (var context = new CollectionContext())
            {
                var products = from p
                             in context.Products
                               select p;
                return products.ToList<Product>();
            }

        }

        public bool insertProductRepo(Product p)
        {
            using (var context = new CollectionContext())
            {
                context.Products.Add(p);
                context.SaveChanges();
            }
            return true;
        }

        public bool deleteProductRepo(int id)
        {
            using (var context = new CollectionContext())
            {
                context.Products.Remove(context.Products.Find(id));
                context.SaveChanges();
            }
            return true;
        }
    }
}