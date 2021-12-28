using Domain.Models;
using Repository.Data;
using Repository.Exceptions;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class CompanyRepository : IRepository<Company>
    {
        bool IRepository<Company>.Create(Company entity)
        {
            try
            {
                if (entity == null)
                    throw new CustomException("Entity is null");
                AppDbContext<Company>.Datas.Add(entity);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        bool IRepository<Company>.Delete(Company entity)
        {
            throw new NotImplementedException();
        }

        Company IRepository<Company>.Get(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        List<Company> IRepository<Company>.GetAll(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Company>.Update(Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
