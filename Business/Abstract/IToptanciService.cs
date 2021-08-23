using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IToptanciService
    {
        IDataResult<List<Toptanci>> GetAll();
        IDataResult<Toptanci> GetById(int toptanciId);
        IResult Add(Toptanci toptanci);
        IResult Update(Toptanci toptanci);
        IResult Delete(Toptanci toptanci);
    }
}
