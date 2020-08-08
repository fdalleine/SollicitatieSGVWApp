using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SollicitatieSGVW.Entity
{
    public class Sollicitant
    {
        public int Id { get; set; }
        [Required]
        public string SollicitantNr { get; set; }
        [Required, MaxLength(50)]
        public string VoorNaam { get; set; }
        [Required, MaxLength(50)]
        public string FamilieNaam { get; set; }
        public string VolledigeNaam { get; set; }
        public string Geslacht { get; set; }
        [Required]
        public DateTime GeboorteDatum { get; set; }
        public DateTime InvulDatum { get; set; }
        public DateTime DatumVrij { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string TelefoonNr { get; set; }
        [Required, MaxLength(150)]
        public string Adres { get; set; }
        [Required, MaxLength(50)]
        public string PostCode { get; set; }
        [Required, MaxLength(50)]
        public string WoonPlaats { get; set; }
        public string RijksregisterNr { get; set; }
        [Required, MaxLength(50)]
        public string Dilpoma { get; set; }
        [Required, MaxLength(50)]
        public string VereisteVakken { get; set; }
        public string Motivatie { get; set; }
        public string CvUrl { get; set; }
        public IEnumerable<TewerkstellingsRecord> TewerkstellingsRecords { get; set; }
    }
}
