using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfeces
{
    public interface IUserMenuService
    {
        UserMenu GetById(int Id);
        List<UserMenu> GetList();
        string Add(UserMenu userMenu);
        List<UserMenuDto> GetListUserMenu();
        string Update(UserMenu userMenu);
        string Delete(UserMenu userMenu);
        object GetById();
    }
}
