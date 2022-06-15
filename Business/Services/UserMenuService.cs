using Business.Services.Interfeces;
using DataAccess.Repositories.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserMenuService : IUserMenuService
    {
        private IUserMenuRepository _userMenuRepository;
        public UserMenuService(IUserMenuRepository userMenuRepository)
        {
            _userMenuRepository = userMenuRepository;
        }

        public UserMenu GetById(int Id)
        {
            return _userMenuRepository.Get(a => a.UserMenuId == Id);
        }

        public List<UserMenu> GetList()
        {
            return _userMenuRepository.GetList().ToList();
        }
        public List<UserMenuDto> GetListUserMenu()
        {
            return new List<UserMenuDto>(_userMenuRepository.GetListUserMenu().ToList());
        }
        public string Add(UserMenu userMenu)
        {
            _userMenuRepository.Add(userMenu);
            return "Ok";
        }
        public string Update(UserMenu userMenu)
        {
            _userMenuRepository.Update(userMenu);
            return "Ok";
        }
        public string Delete(UserMenu userMenu)
        {
            _userMenuRepository.Delete(userMenu);
            return "Ok";
        }

        public object GetById()
        {
            throw new NotImplementedException();
        }
    }
}