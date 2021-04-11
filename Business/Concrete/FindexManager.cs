using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FindexManager : IFindexService
        

    {
        IFindexDal _findexDal;

        public FindexManager(IFindexDal findexDal)
        {
            _findexDal = findexDal;
        }

        public IResult Add(Findex findex)
        {
            _findexDal.Add(findex);
            return new SuccessResult(Messages.FindexAdded);
        }

        public IResult Delete(Findex findex)
        {
            _findexDal.Delete(findex);
            return new SuccessResult(Messages.FindexDeleted);
        }

        public IDataResult<List<Findex>> GetAll()
        {
            return new SuccessDataResult<List<Findex>>(_findexDal.GetAll(),Messages.FindexListed);
        }

        public IDataResult<Findex> GetByUserId(int userId)
        {
            return new SuccessDataResult<Findex>(_findexDal.Get(f => f.UserId == userId),Messages.FindexListed);
        }

        public IResult Update(Findex findex)
        {
            _findexDal.Update(findex);
            return new SuccessResult(Messages.FindexUpdated);
        }

        public IDataResult<Findex> AddFindex(int userId)
        {
            var result = GetByUserId(userId);
            if (result.Data.FindexScore < 1900)
            {
                result.Data.FindexScore += 100;
                Update(result.Data);
            }
            else
            {
                return new ErrorDataResult<Findex>(Messages.findexPointFull);
            }

            return new SuccessDataResult<Findex>(Messages.findexPointAdded);
        }
    }
}
