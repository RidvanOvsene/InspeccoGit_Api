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
    public class MenuService : IMenuService
    {
        private IMenuRepository _menuRepository;
        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public Menu GetById(int Id)
        {
            return _menuRepository.Get(a => a.MenuId == Id);
        }

        public List<Menu> GetList()
        {
            return _menuRepository.GetList().ToList();
        }
        public string Add(Menu menu)
        {
            _menuRepository.Add(menu);
            return "Ok";
        }
        public string Update(Menu menu)
        {
            _menuRepository.Update(menu);
            return "Ok";
        }
        public string Delete(Menu menu)
        {
            _menuRepository.Delete(menu);
            return "Ok";
        }

        public object GetById()
        {
            throw new NotImplementedException();
        }
    }
}