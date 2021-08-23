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
    public class SatisIadeManager:ISatisIadeService
    {
        ISatisIadeDal _SatisIadeDal;

        public SatisIadeManager(ISatisIadeDal SatisIadeDal)
        {
            _SatisIadeDal = SatisIadeDal;
        }

        public IResult Add(SatisIade SatisIade)
        {
            _SatisIadeDal.Add(SatisIade);
            return new SuccessResult(Messages.SatisIadeEklendi);
        }

        public IResult Delete(SatisIade SatisIade)
        {
            _SatisIadeDal.Delete(SatisIade);
            return new SuccessResult(Messages.SatisIadeSilindi);
        }

        public IDataResult<List<SatisIade>> GetAll()
        {
            return new SuccessDataResult<List<SatisIade>>(_SatisIadeDal.GetAll(), Messages.SatisIadelerListelendi);
        }

        public IDataResult<SatisIade> GetById(int SatisIadeId)
        {
            return new SuccessDataResult<SatisIade>(_SatisIadeDal.Get(s => s.SatisIadeId == SatisIadeId));
        }

        public IResult Update(SatisIade SatisIade)
        {
            _SatisIadeDal.Update(SatisIade);
            return new SuccessResult(Messages.SatisIadeGuncellendi);
        }

    }
}
