using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatisIadeService
    {
        IDataResult<List<SatisIade>> GetAll();
        IDataResult<SatisIade> GetById(int satisIadeId);
        IResult Add(SatisIade satisIade);
        IResult Update(SatisIade satisIade);
        IResult Delete(SatisIade satisIade);
    }
}
