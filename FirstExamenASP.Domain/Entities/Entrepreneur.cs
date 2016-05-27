using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Entity.Spatial;

namespace FirstExamenASP.Domain.Entities
{

    [Table("Entrepreneur")]
    public partial class Entrepreneur
    {
        public Entrepreneur()
        {
            Residence = new HashSet<Residence>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIN { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(50)]
        public string Prenom { get; set; }

        [StringLength(150)]
        public string Adresse { get; set; }

        public int? Telephone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<Residence> Residence { get; set; }
    }
}
