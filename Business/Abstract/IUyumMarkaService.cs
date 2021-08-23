using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUyumMarkaService
    {
        IDataResult<List<UyumMarka>> GetAll();
        IDataResult<UyumMarka> GetById(int uyumMarkaId);
        IResult Add(UyumMarka uyumMarka);
        IResult Update(UyumMarka uyumMarka);
        IResult Delete(UyumMarka uyumMarka);
    }
}
