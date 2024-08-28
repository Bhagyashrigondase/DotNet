using ClothingApp.Entities;

namespace ClothingApp.Repositories
{
    public interface IProductRepo
    {

        //Get all products
        List<Product> GetAllProductRepo();

        bool insertProductRepo(Product product);

        bool deleteProductRepo(int id);

    }
}
