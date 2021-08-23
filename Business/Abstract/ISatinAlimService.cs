using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatinAlimService
    {
        IDataResult<List<SatinAlim>> GetAll();
        IDataResult<SatinAlim> GetById(int satinAlimId);
        IResult Add(SatinAlim satinAlim);
        IResult Update(SatinAlim satinAlim);
        IResult Delete(SatinAlim satinAlim);
    }
}
