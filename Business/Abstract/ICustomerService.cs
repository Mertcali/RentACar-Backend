using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<CustomerDetailDto>> GetByUserId(int Id);
        IDataResult<List<CustomerDetailDto>> GetByMail(string email);
        IDataResult<List<CustomerDetailDto>> GetAll();
    }
}
