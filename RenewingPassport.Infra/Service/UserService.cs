using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public List<User> GetUserById(int Id)
        {
            return _userRepository.GetUserById(Id);
        }

        public List<CountDto> GetUsersCount()
        {
            return _userRepository.GetUsersCount();
        }

        public bool Register(User user)
        {
            return _userRepository.Register(user);
        }

        public bool UpdatePassword(User user)
        {
            return _userRepository.UpdatePassword(user);
        }

        public bool UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
