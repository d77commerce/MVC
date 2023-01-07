﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCtest.Infrastructure.Common.Product
{
    public interface IProductRepository :IRepository<Models.Product>
    {
        void Update(Models.Product product);
    }
}
