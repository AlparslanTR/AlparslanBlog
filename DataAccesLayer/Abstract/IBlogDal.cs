﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> kategoriadıgetir();
        List<Blog> kategoriadıgetirYazar(int id);
    }
}
