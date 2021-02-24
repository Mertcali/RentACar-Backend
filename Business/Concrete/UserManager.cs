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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if(user.FirstName.Length<2 && user.LastName.Length<2)
            {

                return new ErrorResult(Messages.UserNameInvalid);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UsersAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UsersDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.UsersListed);
        }

        public IDataResult<User> GetByUserId(int Id)
        {
            //if (DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<User>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == Id), Messages.UsersListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UsersUpdated);
        }
    }
}
