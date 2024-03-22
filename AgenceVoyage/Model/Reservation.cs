using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AgenceVoyage.Model
{
    [Table("Reservation", Schema = "dbo")]
    public  class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        // Propriété de navigation vers le voyage
        public Voyage Voyage { get; set; }

        // Clé étrangère vers la table Voyage
        [ForeignKey("Voyage")]
        public int VoyageId { get; set; }

        // Autres propriétés de la réservation
        public Client Client { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [Required]
        public DateTime DateReservation { get; set; }
    }
}
