using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        IDataResult<List<Musteri>> GetAll();
        IDataResult<Musteri> GetById(int musteriId);
        IResult Add(Musteri musteri);
        IResult Update(Musteri musteri);
        IResult Delete(Musteri musteri);
    }
}
