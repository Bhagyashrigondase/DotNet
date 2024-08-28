using ClothingApp.Entities;
using ClothingApp.Repositories;

namespace ClothingApp.Services
{
    public class ProductService : IProductService
    {



        public List<Product> GetAllProductService()
        {
            IProductRepo _productrepo = new ProductRepo();
            List<Product> products = _productrepo.GetAllProductRepo();
            return products;
        }

        public bool InsertProductService(Product product)
        {
            IProductRepo _productrepo = new ProductRepo();
            return (_productrepo.insertProductRepo(product));

        }

        public bool DeleteProductService(int id)
        {
            IProductRepo _productrepo= new ProductRepo();
            return _productrepo.deleteProductRepo(id);
        }
    }
}
