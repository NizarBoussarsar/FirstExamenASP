using FirstExamenASP.Data.Infrastructure;
using FirstExamenASP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstExamenASP.Data.Repositories
{
    public class DomicileRepository : RepositoryBase<Domicile>, IDomicileRepository
    {
        public DomicileRepository(DatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }

    public interface IDomicileRepository : IRepository<Domicile> { }
}
