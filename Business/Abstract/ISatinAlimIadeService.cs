using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatinAlimIadeService
    {
        IDataResult<List<SatinAlimIade>> GetAll();
        IDataResult<SatinAlimIade> GetById(int satinAlimIadeId);
        IResult Add(SatinAlimIade satinAlimIade);
        IResult Update(SatinAlimIade satinAlimIade);
        IResult Delete(SatinAlimIade satinAlimIade);
    }
}
