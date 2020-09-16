using SollicitatieSGVW.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Models
{
    public class TewerkstellingsRecordCreateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Naam")]
        public int SollicitantId { get; set; }
        
        public Sollicitant Sollicitant { get; set; }

        public string SchoolNaam { get; set; }

        public string VolledigeNaam { get; set; }

        [Display(Name = "School")]
        public int SchoolId { get; set; }

        public Scholen School { get; set; }

        [DataType(DataType.Date), Display(Name = "Startdatum")]
        public DateTime StartDatum { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Date), Display(Name = "Einddatum")]
        public DateTime Einddatum { get; set; } = DateTime.UtcNow;
        
        [StringLength(500)]
        public string Opmerking { get; set; }
    }
}
