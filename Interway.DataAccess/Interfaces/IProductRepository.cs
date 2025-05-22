using InterwayAPI.Domain.Entities;

namespace InterwayAPI.DataAccess.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        List<Product> GetAllFeaturedProducts();
        PagedResultModel<Product> GetFilteredProducts(int? categoryId, int startIndex, int count, string searchValue, string orderByColumn, bool isAscending);
        Product GetById(int id);
        int Insert(Product product);
        void Update(Product product);
        void DeleteById(int id);
    }
}
