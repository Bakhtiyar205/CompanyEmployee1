using Domain.Models;
using Repository.Implementation;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CompanyService : ICompanyService
    {
        private CompanyRepository _companyRepository;
        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }
        public Company Create(Company model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Company model)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public Company GetByName(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public Company Update(int id, Company model)
        {
            throw new NotImplementedException();
        }
    }
}
