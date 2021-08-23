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
    public class SatisDetayManager : ISatisDetayService
    {
        ISatisDetayDal _SatisDetayDal;

        public SatisDetayManager(ISatisDetayDal SatisDetayDal)
        {
            _SatisDetayDal = SatisDetayDal;
        }

        public IResult Add(SatisDetay SatisDetay)
        {
            _SatisDetayDal.Add(SatisDetay);
            return new SuccessResult(Messages.SatisDetayEklendi);
        }

        public IResult Delete(SatisDetay SatisDetay)
        {
            _SatisDetayDal.Delete(SatisDetay);
            return new SuccessResult(Messages.SatisDetaySilindi);
        }

        public IDataResult<List<SatisDetay>> GetAll()
        {
            return new SuccessDataResult<List<SatisDetay>>(_SatisDetayDal.GetAll(), Messages.SatisDetaylarListelendi);
        }

        public IDataResult<SatisDetay> GetById(int SatisDetayId)
        {
            return new SuccessDataResult<SatisDetay>(_SatisDetayDal.Get(s => s.SatisDetayId == SatisDetayId));
        }

        public IResult Update(SatisDetay SatisDetay)
        {
            _SatisDetayDal.Update(SatisDetay);
            return new SuccessResult(Messages.SatisDetayGuncellendi);
        }
    }
}
