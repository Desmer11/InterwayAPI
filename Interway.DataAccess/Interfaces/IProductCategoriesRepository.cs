﻿using InterwayAPI.Domain.Entities;

namespace InterwayAPI.DataAccess.Interfaces
{
    public interface IProductCategoriesRepository
    {
        List<ProductCategory> GetAll();
        PagedResultModel<ProductCategory> GetFilteredProductCategories(int startIndex, int count, string searchValue, string orderByColumn, bool isAscending);
        int Insert(ProductCategory productCategory);
        void Update(ProductCategory productCategory);
        void DeleteById(int id);
        ProductCategory GetById(int id);
    }
}
