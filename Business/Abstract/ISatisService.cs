using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISatisService
    {
        IDataResult<List<Satis>> GetAll();
        IDataResult<Satis> GetById(int satisId);
        IResult Add(Satis satis);
        IResult Update(Satis satis);
        IResult Delete(Satis satis);
    }
}
