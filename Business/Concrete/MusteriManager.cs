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
    public class MusteriManager : IMusteriService
    {
        IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public IResult Add(Musteri musteri)
        {
            _musteriDal.Add(musteri);
            return new SuccessResult(Messages.MusteriEklendi);
        }

        public IResult Delete(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
            return new SuccessResult(Messages.MusteriSilindi);
        }

        public IDataResult<List<Musteri>> GetAll()
        {
            return new SuccessDataResult<List<Musteri>>(_musteriDal.GetAll(), Messages.MusterilerListelendi);
        }

        public IDataResult<Musteri> GetById(int musteriId)
        {
            return new SuccessDataResult<Musteri>(_musteriDal.Get(m => m.MusteriId == musteriId));
        }

        public IResult Update(Musteri musteri)
        {
            _musteriDal.Update(musteri);
            return new SuccessResult(Messages.MusteriGuncellendi);
        }
    }
}
