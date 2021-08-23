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
    public class SatinAlimIadeDetayManager : ISatinAlimIadeDetayService
    {
        ISatinAlimIadeDetayDal _SatinAlimIadeDetayDal;

        public SatinAlimIadeDetayManager(ISatinAlimIadeDetayDal SatinAlimIadeDetayDal)
        {
            _SatinAlimIadeDetayDal = SatinAlimIadeDetayDal;
        }

        public IResult Add(SatinAlimIadeDetay SatinAlimIadeDetay)
        {
            _SatinAlimIadeDetayDal.Add(SatinAlimIadeDetay);
            return new SuccessResult(Messages.SatinAlimIadeDetayEklendi);
        }

        public IResult Delete(SatinAlimIadeDetay SatinAlimIadeDetay)
        {
            _SatinAlimIadeDetayDal.Delete(SatinAlimIadeDetay);
            return new SuccessResult(Messages.SatinAlimIadeDetaySilindi);
        }

        public IDataResult<List<SatinAlimIadeDetay>> GetAll()
        {
            return new SuccessDataResult<List<SatinAlimIadeDetay>>(_SatinAlimIadeDetayDal.GetAll(), Messages.SatinAlimIadeDetaylarListelendi);
        }

        public IDataResult<SatinAlimIadeDetay> GetById(int SatinAlimIadeDetayId)
        {
            return new SuccessDataResult<SatinAlimIadeDetay>(_SatinAlimIadeDetayDal.Get(s => s.SatinAlimIadeDetayId == SatinAlimIadeDetayId));
        }

        public IResult Update(SatinAlimIadeDetay SatinAlimIadeDetay)
        {
            _SatinAlimIadeDetayDal.Update(SatinAlimIadeDetay);
            return new SuccessResult(Messages.SatinAlimIadeDetayGuncellendi);
        }
    }
}
