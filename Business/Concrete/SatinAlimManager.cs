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
    public class SatinAlimManager : ISatinAlimService
    {
        ISatinAlimDal _SatinAlimDal;

        public SatinAlimManager(ISatinAlimDal SatinAlimDal)
        {
            _SatinAlimDal = SatinAlimDal;
        }

        public IResult Add(SatinAlim SatinAlim)
        {
            _SatinAlimDal.Add(SatinAlim);
            return new SuccessResult(Messages.SatinAlimEklendi);
        }

        public IResult Delete(SatinAlim SatinAlim)
        {
            _SatinAlimDal.Delete(SatinAlim);
            return new SuccessResult(Messages.SatinAlimSilindi);
        }

        public IDataResult<List<SatinAlim>> GetAll()
        {
            return new SuccessDataResult<List<SatinAlim>>(_SatinAlimDal.GetAll(), Messages.SatinAlimlarListelendi);
        }

        public IDataResult<SatinAlim> GetById(int SatinAlimId)
        {
            return new SuccessDataResult<SatinAlim>(_SatinAlimDal.Get(s => s.SatinAlimId == SatinAlimId));
        }

        public IResult Update(SatinAlim SatinAlim)
        {
            _SatinAlimDal.Update(SatinAlim);
            return new SuccessResult(Messages.SatinAlimGuncellendi);
        }
    }
}
