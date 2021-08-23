using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYapilanOdemeService
    {
        IDataResult<List<YapilanOdeme>> GetAll();
        IDataResult<YapilanOdeme> GetById(int yapilanOdemeId);
        IResult Add(YapilanOdeme yapilanOdeme);
        IResult Update(YapilanOdeme yapilanOdeme);
        IResult Delete(YapilanOdeme yapilanOdeme);
    }
}
