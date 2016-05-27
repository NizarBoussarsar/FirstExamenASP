using FirstExamenASP.Data.Infrastructure;
using FirstExamenASP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Service
{
    public class MyService : IMyService
    {
        static DatabaseFactory dbFactory;
        IUnitOfWork utOfWork;

        public MyService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }

        public string GetFirstLetters(string nom, string prenom)
        {
            return prenom.Substring(0, 1) + nom.Substring(0, 1);
        }

        public IQueryable<Domicile> GetDomiciles()
        {
            return utOfWork.DomicileRepository.GetAll();
        }

        public IQueryable<Entrepreneur> GetEntrepreneurs()
        {
            return utOfWork.EntrepreneurRepository.GetAll();
        }

        public bool AddEntrepreneur(Entrepreneur entrepreneur)
        {
            utOfWork.EntrepreneurRepository.Add(entrepreneur);
            utOfWork.Commit();
            return true;
        }

    }
}
