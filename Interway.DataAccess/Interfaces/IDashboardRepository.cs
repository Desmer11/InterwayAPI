using InterwayAPI.Domain.Entities;

namespace InterwayAPI.DataAccess.Interfaces
{
    public interface IDashboardRepository
    {
        int CountCustomers();

        int CountActiveProducts();
        int CountDeletedProducts();

        int CountInvoices();
        int CountPendingInvoices();
        int CountPaidInvoices();
        int CountCanceledInvoices();
        decimal GetInvoicesTotalAmount();

        int CountOrders();
        int CountPendingOrders();
        int CountAcceptedOrders();
        int CountRejectedOrders();
        decimal GetOrdersTotalAmount();

        List<User> GetAdministrators();

    }
}
