﻿using Core.Untilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buisness.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById();
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
