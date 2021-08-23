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
    public class UyumMarkaManager : IUyumMarkaService
    {
        IUyumMarkaDal _uyumMarkaDal;

        public UyumMarkaManager(IUyumMarkaDal uyumMarkaDal)
        {
            _uyumMarkaDal = uyumMarkaDal;
        }

        public IResult Add(UyumMarka uyumMarka)
        {
            _uyumMarkaDal.Add(uyumMarka);
            return new SuccessResult(Messages.UyumMarkaEklendi);
        }

        public IResult Delete(UyumMarka uyumMarka)
        {
            _uyumMarkaDal.Delete(uyumMarka);
            return new SuccessResult(Messages.UyumMarkaSilindi);
        }

        public IDataResult<List<UyumMarka>> GetAll()
        {
            return new SuccessDataResult<List<UyumMarka>>(_uyumMarkaDal.GetAll(), Messages.UyumMarkalarListelendi);
        }

        public IDataResult<UyumMarka> GetById(int uyumMarkaId)
        {
            return new SuccessDataResult<UyumMarka>(_uyumMarkaDal.Get(u => u.UyumMarkaId == uyumMarkaId));
        }

        public IResult Update(UyumMarka uyumMarka)
        {
            _uyumMarkaDal.Update(uyumMarka);
            return new SuccessResult(Messages.UyumMarkaGuncellendi);
        }
    }
}
