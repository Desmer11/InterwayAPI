using InterwayAPI.Domain.Entities;

namespace InterwayAPI.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        User GetByEmail(string email);
        User GetById(int id);
        int Insert(User entity);
    }
}
