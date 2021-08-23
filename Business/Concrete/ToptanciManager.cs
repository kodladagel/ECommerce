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
    public class ToptanciManager : IToptanciService
    {
        IToptanciDal _toptanciDal;

        public ToptanciManager(IToptanciDal toptanciDal)
        {
            _toptanciDal = toptanciDal;
        }

        public IResult Add(Toptanci toptanci)
        {
            _toptanciDal.Add(toptanci);
            return new SuccessResult(Messages.ToptanciEklendi);
        }

        public IResult Delete(Toptanci toptanci)
        {
            _toptanciDal.Delete(toptanci);
            return new SuccessResult(Messages.ToptanciSilindi);
        }

        public IDataResult<List<Toptanci>> GetAll()
        {
            return new SuccessDataResult<List<Toptanci>>(_toptanciDal.GetAll(), Messages.ToptancilarListelendi);
        }

        public IDataResult<Toptanci> GetById(int toptanciId)
        {
            return new SuccessDataResult<Toptanci>(_toptanciDal.Get(t=>t.ToptanciId == toptanciId));
        }

        public IResult Update(Toptanci toptanci)
        {
            _toptanciDal.Update(toptanci);
            return new SuccessResult(Messages.ToptanciGuncellendi);
        }
    }
}
