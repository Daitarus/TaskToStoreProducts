﻿using RepositoryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskToStoreProducts.DataBase.Entities;

namespace TaskToStoreProducts.DataBase.Repositories
{
    internal class AttributeRepository : Repository<AttributeEntity>
    {
        public AttributeRepository(ProductsDataBase dataBase) : base(dataBase) 
        { 

        }
    }
}