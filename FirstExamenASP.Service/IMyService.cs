using FirstExamenASP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamenASP.Service
{
    public interface IMyService
    {
        string GetFirstLetters(string nom, string prenom);
        IQueryable<Domicile> GetDomiciles();
        IQueryable<Entrepreneur> GetEntrepreneurs();
        bool AddEntrepreneur(Entrepreneur entrepreneur);
    }
}
