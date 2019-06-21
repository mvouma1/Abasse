using System.Collections.Generic;
using System.Text;
using Abasse.Domain.Entities.Catalog;

namespace Abasse.Contracts.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        Product GetProduct(int id);
        bool RemoveProduct(int id);
        ICollection<Product> GetAllProduct();
    }
}
