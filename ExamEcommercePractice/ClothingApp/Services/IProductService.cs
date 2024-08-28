using ClothingApp.Entities;

namespace ClothingApp.Services
{
    public interface IProductService
    {

        List<Product> GetAllProductService();

        bool InsertProductService(Product product);

        bool DeleteProductService(int id);
    }
}
