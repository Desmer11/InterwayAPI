﻿using InterwayAPI.ViewModels.Models;

namespace InterwayAPI.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(OrderViewModel orderViewModel);
        Task<PagedResultViewModel<OrderViewModel>> GetFilteredOrders(DatatableRequestViewModel datatableRequestViewModel);
        Task<OrderViewModel> GetById(int id);
        Task RejectOrder(int id);
        Task AcceptOrder(int id);
    }
}
