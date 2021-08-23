using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatinAlimDetayService
    {
        IDataResult<List<SatinAlimDetay>> GetAll();
        IDataResult<SatinAlimDetay> GetById(int satinAlimDetayId);
        IResult Add(SatinAlimDetay satinAlimDetay);
        IResult Update(SatinAlimDetay satinAlimDetay);
        IResult Delete(SatinAlimDetay satinAlimDetay);
    }
}
