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
    public class AlinanOdemeManager : IAlinanOdemeService
    {
        IAlinanOdemeDal _alinanOdemeDal;

        public AlinanOdemeManager(IAlinanOdemeDal alinanOdemeDal)
        {
            _alinanOdemeDal = alinanOdemeDal;
        }

        public IResult Add(AlinanOdeme alinanOdeme)
        {
            _alinanOdemeDal.Add(alinanOdeme);
            return new SuccessResult(Messages.AlinanOdemeEklendi);
        }

        public IResult Delete(AlinanOdeme alinanOdeme)
        {
            _alinanOdemeDal.Delete(alinanOdeme);
            return new SuccessResult(Messages.AlinanOdemeSilindi);
        }

        public IDataResult<List<AlinanOdeme>> GetAll()
        {
            return new SuccessDataResult<List<AlinanOdeme>>(_alinanOdemeDal.GetAll(), Messages.AlinanOdemelerListelendi);
        }

        public IDataResult<AlinanOdeme> GetById(int alinanOdemeId)
        {
            return new SuccessDataResult<AlinanOdeme>(_alinanOdemeDal.Get(a => a.AlinanOdemeId == alinanOdemeId));
        }

        public IResult Update(AlinanOdeme alinanOdeme)
        {
            _alinanOdemeDal.Update(alinanOdeme);
            return new SuccessResult(Messages.AlinanOdemeSilindi);
        }
    }
}
