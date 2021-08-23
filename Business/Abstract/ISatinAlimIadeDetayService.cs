using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatinAlimIadeDetayService
    {
        IDataResult<List<SatinAlimIadeDetay>> GetAll();
        IDataResult<SatinAlimIadeDetay> GetById(int satinAlimIadeDetayId);
        IResult Add(SatinAlimIadeDetay satinAlimIadeDetay);
        IResult Update(SatinAlimIadeDetay satinAlimIadeDetay);
        IResult Delete(SatinAlimIadeDetay satinAlimIadeDetay);
    }
}
