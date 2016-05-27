using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace FirstExamenASP.Domain.Entities
{

    [Table("Residence")]
    public partial class Residence
    {
        public Residence()
        {
            Domicile = new HashSet<Domicile>();
        }

        public int Id { get; set; }

        public int? NbreDomicile { get; set; }

        public double? Surface { get; set; }

        public int? IdEntrepreneur { get; set; }

        public virtual ICollection<Domicile> Domicile { get; set; }

        public virtual Entrepreneur Entrepreneur { get; set; }
    }
}
