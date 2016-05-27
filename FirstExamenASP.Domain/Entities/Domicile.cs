using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace FirstExamenASP.Domain.Entities
{

    [Table("Domicile")]
    public partial class Domicile
    {
        public int Id { get; set; }

        public int? Surface { get; set; }

        public int? NbrePiece { get; set; }

        public double? Prix { get; set; }  

        public int? IdResidence { get; set; }

        public virtual Residence Residence { get; set; }
    }
}
