using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMarkaService
    {
        IDataResult<List<Marka>> GetAll();
        IDataResult<Marka> GetById(int markaId);
        IResult Add(Marka marka);
        IResult Update(Marka marka);
        IResult Delete(Marka marka);
    }
}
