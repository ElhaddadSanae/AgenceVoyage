using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenceVoyage.Model
{
    [Table("Client", Schema = "dbo")]
    public class Client
    {
        [Key]
        [Column("ClientId")]
        public int ClientId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Nom")]
        public string Nom { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Prenom")]
        public string Prenom { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NumeroTelephone")]
        public string NumeroTelephone { get; set; }

        [Required]
        [Column("DateNaissance")]
        public DateTime DateNaissance { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("Genre")]
        public string Genre { get; set; }

        [Required]
        [Column("PointsFidelite")]
        public int PointsFidelite { get; set; }

        [InverseProperty("clients")]
        public ICollection<Voyage> Voyages { get; set; }
    }
}
