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
    public class SatisManager : ISatisService
    {
        ISatisDal _satisDal;

        public SatisManager(ISatisDal satisDal)
        {
            _satisDal = satisDal;
        }

        public IResult Add(Satis satis)
        {
            _satisDal.Add(satis);
            return new SuccessResult(Messages.SatisEklendi);
        }

        public IResult Delete(Satis satis)
        {
            _satisDal.Delete(satis);
            return new SuccessResult(Messages.SatisSilindi);
        }

        public IDataResult<List<Satis>> GetAll()
        {
            return new SuccessDataResult<List<Satis>>(_satisDal.GetAll(), Messages.SatislarListelendi);
        }

        public IDataResult<Satis> GetById(int satisId)
        {
            return new SuccessDataResult<Satis>(_satisDal.Get(s => s.SatisId == satisId));
        }

        public IResult Update(Satis satis)
        {
            _satisDal.Update(satis);
            return new SuccessResult(Messages.SatisGuncellendi);
        }
    }
}
