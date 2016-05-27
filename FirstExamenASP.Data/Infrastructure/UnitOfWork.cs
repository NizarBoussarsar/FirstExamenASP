using FirstExamenASP.Data.Repositories;
using FirstExamenASP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private FirstExamenASPDB dataContext;
        DatabaseFactory dbFactory;

        public UnitOfWork(DatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        protected FirstExamenASPDB DataContext
        {
            get { return dataContext ?? (dataContext = dbFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }

        private IDomicileRepository domicileRepository;
        public IDomicileRepository DomicileRepository
        {
            get { return domicileRepository ?? (domicileRepository = new DomicileRepository(dbFactory)); }
        }

        private IEntrepreneurRepository entrepreneurRepository;
        public IEntrepreneurRepository EntrepreneurRepository
        {
            get { return entrepreneurRepository ?? (entrepreneurRepository = new EntrepreneurRepository(dbFactory)); }
        }

        private IResidenceRepository residenceRepository;
        public IResidenceRepository ResidenceRepository
        {
            get { return residenceRepository ?? (residenceRepository = new ResidenceRepository(dbFactory)); }
        }
    }

}
