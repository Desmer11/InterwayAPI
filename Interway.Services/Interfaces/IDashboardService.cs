using InterwayAPI.DataAccess.Interfaces;

namespace InterwayAPI.Services.Interfaces
{
    public interface IDashboardService
    {
        DashboardViewModel GetDashboardData();
    }
}
