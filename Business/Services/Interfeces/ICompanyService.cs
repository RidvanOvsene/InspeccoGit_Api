using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfeces
{
    public interface ICompanyService
    {
        Company GetById(int Id);
        List<Company> GetList();
        string Add(Company company);
        string Update(Company company);
        string Delete(Company company);
        object GetById();
    }
}
