﻿using InterwayAPI.DataAccess.DataContext;
using InterwayAPI.DataAccess.Interfaces;
using InterwayAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterwayAPI.DataAccess.Implementations
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            
        }

        public User GetByEmail(string email)
        {
            return _applicationDbContext.Users
                .Include(x => x.Role)
                .FirstOrDefault(x => x.Email == email);
        }

        public User GetById(int id)
        {
            return _applicationDbContext.Users
                .Include(x => x.Role)
                .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(User entity)
        {
            _applicationDbContext.Users.Add(entity);
            _applicationDbContext.SaveChanges();
            return entity.Id;
        }
    }
}
