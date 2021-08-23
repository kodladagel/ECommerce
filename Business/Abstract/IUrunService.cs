using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunService
    {
        IDataResult<List<Urun>> GetAll();
        IDataResult<Urun> GetById(int urunId);
        IResult Add(Urun urun);
        IResult Update(Urun urun);
        IResult Delete(Urun urun);
    }
}
