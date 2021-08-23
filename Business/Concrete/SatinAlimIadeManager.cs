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
    public class SatinAlimIadeManager:ISatinAlimIadeService
    {
        ISatinAlimIadeDal _SatinAlimIadeDal;

        public SatinAlimIadeManager(ISatinAlimIadeDal SatinAlimIadeDal)
        {
            _SatinAlimIadeDal = SatinAlimIadeDal;
        }

        public IResult Add(SatinAlimIade SatinAlimIade)
        {
            _SatinAlimIadeDal.Add(SatinAlimIade);
            return new SuccessResult(Messages.SatinAlimIadeEklendi);
        }

        public IResult Delete(SatinAlimIade SatinAlimIade)
        {
            _SatinAlimIadeDal.Delete(SatinAlimIade);
            return new SuccessResult(Messages.SatinAlimIadeSilindi);
        }

        public IDataResult<List<SatinAlimIade>> GetAll()
        {
            return new SuccessDataResult<List<SatinAlimIade>>(_SatinAlimIadeDal.GetAll(), Messages.SatinAlimIadelerListelendi);
        }

        public IDataResult<SatinAlimIade> GetById(int SatinAlimIadeId)
        {
            return new SuccessDataResult<SatinAlimIade>(_SatinAlimIadeDal.Get(s => s.SatinAlimIadeId == SatinAlimIadeId));
        }

        public IResult Update(SatinAlimIade SatinAlimIade)
        {
            _SatinAlimIadeDal.Update(SatinAlimIade);
            return new SuccessResult(Messages.SatinAlimIadeGuncellendi);
        }
    }
}
