using FirstExamenASP.Data.Infrastructure;
using FirstExamenASP.Data.Repositories;
using FirstExamenASP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Service
{
    public class ServiceToTest
    {
        static DatabaseFactory dbFactory;
        IUnitOfWork utOfWork;
        private Data.Repositories.IDomicileRepository repository;

        public ServiceToTest()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }

        IDomicileRepository repo = null;

        public ServiceToTest(Data.Repositories.IDomicileRepository repository)
        {
            // TODO: Complete member initialization
            repo = repository;
        }

        //Methode à tester
        public IQueryable<Domicile> GetDomicilesByPrice(double? Prix)
        {
            return repo.GetMany(d => d.Prix <= Prix.Value);
        }
    }
}
