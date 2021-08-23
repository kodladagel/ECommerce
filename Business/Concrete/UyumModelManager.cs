using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UyumModelManager : IUyumModelService
    {
        IUyumModelDal _uyumModelDal;

        public UyumModelManager(IUyumModelDal uyumModelDal)
        {
            _uyumModelDal = uyumModelDal;
        }

        public IResult Add(UyumModel uyumModel)
        {
            _uyumModelDal.Add(uyumModel);
            return new SuccessResult(Messages.UyumModelEklendi);
        }

        public IResult Delete(UyumModel uyumModel)
        {
            _uyumModelDal.Delete(uyumModel);
            return new SuccessResult(Messages.UyumModelSilindi);
        }

        public IDataResult<List<UyumModel>> GetAll()
        {
            return new SuccessDataResult<List<UyumModel>>(_uyumModelDal.GetAll(), Messages.UyumModellerListelendi);
        }

        public IDataResult<UyumModel> GetById(int uyumModelId)
        {
            return new SuccessDataResult<UyumModel>(_uyumModelDal.Get(u => u.UyumModelId == uyumModelId));
        }

        public IResult Update(UyumModel uyumModel)
        {
            _uyumModelDal.Update(uyumModel);
            return new SuccessResult(Messages.UyumModelGuncellendi);
        }
    }
}
