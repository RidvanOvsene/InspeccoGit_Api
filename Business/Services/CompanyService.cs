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
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository _userRepository;
        public CompanyService(ICompanyRepository CompaniRepository)
        {
            _userRepository = CompaniRepository;
        }

        public Company GetById(int Id)
        {
            return _userRepository.Get(a => a.CompanyId == Id);
        }

        public List<Company> GetList()
        {
            return _userRepository.GetList().ToList();
        }
        public string Add(Company Compani)
        {
            _userRepository.Add(Compani);
            return "Ok";
        }
        public string Update(Company Compani)
        {
            _userRepository.Update(Compani);
            return "Ok";
        }
        public string Delete(Company Compani)
        {
            _userRepository.Delete(Compani);
            return "Ok";
        }

        public object GetById()
        {
            throw new NotImplementedException();
        }
    }
}