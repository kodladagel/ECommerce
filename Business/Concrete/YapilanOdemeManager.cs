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
    public class YapilanOdemeManager : IYapilanOdemeService
    {
        IYapilanOdemeDal _YapilanOdemeDal;

        public YapilanOdemeManager(IYapilanOdemeDal YapilanOdemeDal)
        {
            _YapilanOdemeDal = YapilanOdemeDal;
        }

        public IResult Add(YapilanOdeme YapilanOdeme)
        {
            _YapilanOdemeDal.Add(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeEklendi);
        }

        public IResult Delete(YapilanOdeme YapilanOdeme)
        {
            _YapilanOdemeDal.Delete(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeSilindi);
        }

        public IDataResult<List<YapilanOdeme>> GetAll()
        {
            return new SuccessDataResult<List<YapilanOdeme>>(_YapilanOdemeDal.GetAll(), Messages.YapilanOdemelerListelendi);
        }

        public IDataResult<YapilanOdeme> GetById(int YapilanOdemeId)
        {
            return new SuccessDataResult<YapilanOdeme>(_YapilanOdemeDal.Get(a => a.YapilanOdemeId == YapilanOdemeId));
        }

        public IResult Update(YapilanOdeme YapilanOdeme)
        {
            _YapilanOdemeDal.Update(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeSilindi);
        }
    }
    }
