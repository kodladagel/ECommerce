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
    public class UrunManager:IUrunService
    {
        IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        [ValidationAspect(typeof(UrunValidator))]
        public IResult Add(Urun urun)
        {
            _urunDal.Add(urun);
            return new SuccessResult(Messages.UrunEklendi);
        }

        public IResult Delete(Urun urun)
        {
            _urunDal.Delete(urun);
            return new SuccessResult(Messages.UrunSilindi);
        }

        public IDataResult<List<Urun>> GetAll()
        {
            return new SuccessDataResult<List<Urun>>(_urunDal.GetAll(), Messages.UrunlerListelendi);
        }

        public IDataResult<Urun> GetById(int urunId)
        {
            return new SuccessDataResult<Urun>(_urunDal.Get(u => u.UrunId == urunId));
        }

        public IResult Update(Urun urun)
        {
            _urunDal.Update(urun);
            return new SuccessResult(Messages.UrunGuncellendi);
        }
    }
}
