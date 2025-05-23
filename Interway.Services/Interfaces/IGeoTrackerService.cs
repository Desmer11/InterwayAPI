using InterwayAPI.Services.Models;

namespace InterwayAPI.Services.Interfaces
{
    public interface IGeoTrackerService
    {
        string GetCoutryFlagUrl(string countryCode);
        Task<IpGeoInfo> GetIpGeoInfoAsync(string ipAddress);
    }
}
