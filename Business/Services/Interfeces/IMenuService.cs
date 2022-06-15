using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfeces
{
    public interface IMenuService
    {
        Menu GetById(int Id);
        List<Menu> GetList();
        string Add(Menu menu);
        string Update(Menu menu);
        string Delete(Menu menu);
        object GetById();
    }
}
