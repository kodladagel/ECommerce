using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatisDetayService
    {
        IDataResult<List<SatisDetay>> GetAll();
        IDataResult<SatisDetay> GetById(int satisDetayId);
        IResult Add(SatisDetay satisDetay);
        IResult Update(SatisDetay satisDetay);
        IResult Delete(SatisDetay satisDetay);
    }
}
