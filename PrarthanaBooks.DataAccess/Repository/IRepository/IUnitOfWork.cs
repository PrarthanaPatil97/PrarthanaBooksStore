﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrarthanaBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}