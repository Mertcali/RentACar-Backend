using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
        //List<Color> GetById(int colorId);
    }
}
