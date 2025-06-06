﻿using InterwayAPI.Domain.Entities;

namespace InterwayAPI.DataAccess.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<int> GetMaxIdAsync();
        Task<int> InsertAsync(Invoice invoice);
        Task<List<Invoice>> GetAllAsync();
        Task<Invoice> GetByIdAsync(int id);
        Task UpdateAsync(Invoice invoice);
        Task<PagedResultModel<Invoice>> GetFilteredAsync(int startIndex, int count, string searchValue, string orderByColumn, bool isAscending);
    }
}
