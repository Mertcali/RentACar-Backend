using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FakeCardManager : IFakeCardService

       
    {
        IFakeCardDal _fakeCardDal;

        public FakeCardManager(IFakeCardDal fakeCardDal)
        {
            _fakeCardDal = fakeCardDal;
        }

        [ValidationAspect(typeof(FakeCardValidator))]
        public IResult Add(FakeCard fakeCard)
        {
            _fakeCardDal.Add(fakeCard);
            return new SuccessResult(Messages.FakeCardAdded);
        }

        public IResult Delete(FakeCard fakeCard)
        {
            _fakeCardDal.Delete(fakeCard);
            return new SuccessResult(Messages.FakeCardDeleted);
        }

        public IDataResult<List<FakeCard>> GetAll()
        {
            return new SuccessDataResult<List<FakeCard>>(_fakeCardDal.GetAll(), Messages.FakeCardsListed);
        }

        public IDataResult<List<FakeCard>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<FakeCard>>(_fakeCardDal.GetAll(c => c.CardNumber == cardNumber), Messages.FakeCardsListed);
        }

        public IDataResult<FakeCard> GetById(int cardId)
        {
            return new SuccessDataResult<FakeCard>(_fakeCardDal.Get(c => c.Id == cardId), Messages.FakeCardsListed);
        }

        public IResult IsCardExist(FakeCard fakeCard)
        {
            var result = _fakeCardDal.Get(c => c.NameOnCard == fakeCard.NameOnCard && c.CardNumber == fakeCard.CardNumber && c.CardCVV == fakeCard.CardCVV);
            if (result == null)
            {
                return new ErrorResult(Messages.CardCannotFound);
            }
            return new SuccessResult(Messages.CardExists);
        }

        public IResult Update(FakeCard fakeCard)
        {
            _fakeCardDal.Update(fakeCard);
            return new SuccessResult(Messages.FakeCardUpdated);
        }
    }
}
