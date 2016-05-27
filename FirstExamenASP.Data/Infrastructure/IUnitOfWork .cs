using FirstExamenASP.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
        IDomicileRepository DomicileRepository { get; }
        IEntrepreneurRepository EntrepreneurRepository { get;}
        IResidenceRepository ResidenceRepository { get; }
    }

}
