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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if(color.ColorName.Length<2)
            {
                return new ErrorResult(Messages.ColorNameInvalid);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorsAdded);
            
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorsDeleted);
           
        }

        public IDataResult<List<Color>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);

        }

        public IDataResult<List<Color>> GetById(int colorId)
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c=> c.ColorId == colorId), Messages.ColorsListed);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorsUpdated);
        }
    }
}
