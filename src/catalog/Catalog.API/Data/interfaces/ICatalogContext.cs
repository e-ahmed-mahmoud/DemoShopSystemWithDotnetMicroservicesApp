﻿using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data.interfaces
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Product { get; }
    }
}
