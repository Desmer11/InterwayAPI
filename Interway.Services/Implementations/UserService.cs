using AutoMapper;
using InterwayAPI.DataAccess.Interfaces;
using InterwayAPI.Domain.Constants;
using InterwayAPI.Domain.Entities;
using InterwayAPI.Services.Helpers;
using InterwayAPI.Services.Interfaces;
using InterwayAPI.ViewModels.Models;
using Microsoft.AspNetCore.Identity;

namespace InterwayAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserViewModel GetUserById(int id)
        {
            var user = _userRepository.GetById(id);
            return _mapper.Map<UserViewModel>(user);
        }

        public UserViewModel RegisterUser(RegisterUserViewModel registerUserViewModel)
        {
            var user = _mapper.Map<User>(registerUserViewModel);
            PasswordHashedHelper.HashPassword(user, registerUserViewModel.Password);
            user.RoleKey = Roles.User;
            var userId = _userRepository.Insert(user);
            if (userId <= 0)
            {
                throw new Exception("User not saved.");
            }
            return GetUserById(userId);
        }

        public UserViewModel ValidateUser(UserCredentialsViewModel userCredentialsViewModel)
        {
            var user = _userRepository.GetByEmail(userCredentialsViewModel.Email);
            if (user is null)
            {
                return null; 
            }

            var passwordVerificationResult = PasswordHashedHelper.VerifyHashedPassword(user, userCredentialsViewModel.Password);
            if (passwordVerificationResult == PasswordVerificationResult.Failed)
            {
                return new UserViewModel();
            }

            var mappedUser = _mapper.Map<UserViewModel>(user);
            return mappedUser;
        }
    }
}
