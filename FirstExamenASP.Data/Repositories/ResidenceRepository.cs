using FirstExamenASP.Data.Infrastructure;
using FirstExamenASP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Data.Repositories
{
    public class ResidenceRepository : RepositoryBase<Residence>, IResidenceRepository
    {
        public ResidenceRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }

    public interface IResidenceRepository : IRepository<Residence> { }
}
