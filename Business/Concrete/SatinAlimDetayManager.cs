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
    public class SatinAlimDetayManager : ISatinAlimDetayService
    {
        ISatinAlimDetayDal _SatinAlimDetayDal;

        public SatinAlimDetayManager(ISatinAlimDetayDal SatinAlimDetayDal)
        {
            _SatinAlimDetayDal = SatinAlimDetayDal;
        }

        public IResult Add(SatinAlimDetay SatinAlimDetay)
        {
            _SatinAlimDetayDal.Add(SatinAlimDetay);
            return new SuccessResult(Messages.SatinAlimDetayEklendi);
        }

        public IResult Delete(SatinAlimDetay SatinAlimDetay)
        {
            _SatinAlimDetayDal.Delete(SatinAlimDetay);
            return new SuccessResult(Messages.SatinAlimDetaySilindi);
        }

        public IDataResult<List<SatinAlimDetay>> GetAll()
        {
            return new SuccessDataResult<List<SatinAlimDetay>>(_SatinAlimDetayDal.GetAll(), Messages.SatinAlimDetaylarListelendi);
        }

        public IDataResult<SatinAlimDetay> GetById(int SatinAlimDetayId)
        {
            return new SuccessDataResult<SatinAlimDetay>(_SatinAlimDetayDal.Get(s => s.SatinAlimDetayId == SatinAlimDetayId));
        }

        public IResult Update(SatinAlimDetay SatinAlimDetay)
        {
            _SatinAlimDetayDal.Update(SatinAlimDetay);
            return new SuccessResult(Messages.SatinAlimDetayGuncellendi);
        }
    }
}
