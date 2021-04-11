using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFindexService
    {
        IResult Add(Findex findex);
        IResult Delete(Findex findex);
        IResult Update(Findex findex);
        IDataResult<List<Findex>> GetAll();
        IDataResult<Findex> GetByUserId(int userId);
        IDataResult<Findex> AddFindex(int userId);

    }
}
