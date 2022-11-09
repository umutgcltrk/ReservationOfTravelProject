﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T t);
        void Remove(T t);
        void Update(T t);
        List<T> GetAllList();
        T GetTById(int id);
    }
}
