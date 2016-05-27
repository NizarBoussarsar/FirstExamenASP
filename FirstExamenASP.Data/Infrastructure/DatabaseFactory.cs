﻿using FirstExamenASP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private FirstExamenASPDB dataContext = null;
        public FirstExamenASPDB Get()
        {
            return dataContext ?? (dataContext = new FirstExamenASPDB());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }

}
