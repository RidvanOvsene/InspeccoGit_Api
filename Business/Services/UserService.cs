using Business.Services.Interfeces;
using Core;
using DataAccess.Repositories.Interfaces;
using Entities;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Business.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository UserRepository)
        {
            _userRepository = UserRepository;
        }
        public Users GetById(int Id)
        {
            return _userRepository.Get(a => a.UserId == Id);
        }
        public Users Login(string UserName, string Password)
        {
            return _userRepository.Get(a => a.UserName == UserName && a.Password == Password);
        }
        public List<Users> GetList()
        {
            return _userRepository.GetList().ToList();
        }
        public List<UsersDto> GetListUserRol()
        {
            return new List<UsersDto>(_userRepository.GetListUserRol().ToList());
        }
        public UsersDto GetListUserRol(string Username, string Password)
        {

            return _userRepository.GetListUserRol().FirstOrDefault(x => x.UserName == Username && x.Password == Password);
        }
        public string Add(Users User)
        {
            _userRepository.Add(User);
            return "Ok";
        }
        public string Update(Users User)
        {
            _userRepository.Update(User);
            return "Ok";
        }
        public string Delete(Users User)
        {
            _userRepository.Delete(User);
            return "Ok";
        }
        public object GetById()
        {
            throw new NotImplementedException();
        }
        public List<OperationClaim> GetClaims(Users user)
        {
            return _userRepository.GetClaims(user);
        }

    }
}