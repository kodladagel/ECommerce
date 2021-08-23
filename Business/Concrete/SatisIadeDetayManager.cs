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
    public class SatisIadeDetayManager : ISatisIadeDetayService
    {
        ISatisIadeDetayDal _SatisIadeDetayDal;

        public SatisIadeDetayManager(ISatisIadeDetayDal SatisIadeDetayDal)
        {
            _SatisIadeDetayDal = SatisIadeDetayDal;
        }

        public IResult Add(SatisIadeDetay SatisIadeDetay)
        {
            _SatisIadeDetayDal.Add(SatisIadeDetay);
            return new SuccessResult(Messages.SatisIadeDetayEklendi);
        }

        public IResult Delete(SatisIadeDetay SatisIadeDetay)
        {
            _SatisIadeDetayDal.Delete(SatisIadeDetay);
            return new SuccessResult(Messages.SatisIadeDetaySilindi);
        }

        public IDataResult<List<SatisIadeDetay>> GetAll()
        {
            return new SuccessDataResult<List<SatisIadeDetay>>(_SatisIadeDetayDal.GetAll(), Messages.SatisIadeDetaylarListelendi);
        }

        public IDataResult<SatisIadeDetay> GetById(int SatisIadeDetayId)
        {
            return new SuccessDataResult<SatisIadeDetay>(_SatisIadeDetayDal.Get(s => s.SatisIadeDetayId == SatisIadeDetayId));
        }

        public IResult Update(SatisIadeDetay SatisIadeDetay)
        {
            _SatisIadeDetayDal.Update(SatisIadeDetay);
            return new SuccessResult(Messages.SatisIadeDetayGuncellendi);
        }
    }
}
