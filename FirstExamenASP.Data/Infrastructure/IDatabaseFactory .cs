using FirstExamenASP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        FirstExamenASPDB Get();
    }

}
