﻿using OC_System.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System_DataAccess.Repos.Common
{
    public abstract class RepositoryBase
    {
        protected ApplicationContext _context;
        protected RepositoryBase(ApplicationContext context) { _context = context; }

    }
}
