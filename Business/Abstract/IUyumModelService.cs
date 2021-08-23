using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUyumModelService
    {
        IDataResult<List<UyumModel>> GetAll();
        IDataResult<UyumModel> GetById(int uyumModelId);
        IResult Add(UyumModel uyumModel);
        IResult Update(UyumModel uyumModel);
        IResult Delete(UyumModel uyumModel);
    }
}