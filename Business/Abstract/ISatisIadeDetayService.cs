using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatisIadeDetayService
    {
        IDataResult<List<SatisIadeDetay>> GetAll();
        IDataResult<SatisIadeDetay> GetById(int satisIadeDetayId);
        IResult Add(SatisIadeDetay satisIadeDetay);
        IResult Update(SatisIadeDetay satisIadeDetay);
        IResult Delete(SatisIadeDetay satisIadeDetay);
    }
}
