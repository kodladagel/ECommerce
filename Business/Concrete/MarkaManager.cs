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
    public class MarkaManager : IMarkaService
    {
        IMarkaDal _markaDal;

        public MarkaManager(IMarkaDal markaDal)
        {
            _markaDal = markaDal;
        }

        public IResult Add(Marka marka)
        {
            _markaDal.Add(marka);
            return new SuccessResult(Messages.MarkaEklendi);
        }

        public IResult Delete(Marka marka)
        {
            _markaDal.Delete(marka);
            return new SuccessResult(Messages.MarkaSilindi);
        }

        public IDataResult<List<Marka>> GetAll()
        {
            return new SuccessDataResult<List<Marka>>(_markaDal.GetAll(), Messages.MarkalarListelendi);
        }

        public IDataResult<Marka> GetById(int markaId)
        {
            return new SuccessDataResult<Marka>(_markaDal.Get(m => m.MarkaId == markaId));
        }

        public IResult Update(Marka marka)
        {
            _markaDal.Update(marka);
            return new SuccessResult(Messages.MarkaGuncellendi);
        }
    }
}
