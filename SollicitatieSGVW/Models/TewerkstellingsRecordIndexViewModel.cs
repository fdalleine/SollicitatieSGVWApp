using SollicitatieSGVW.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Models
{
    public class TewerkstellingsRecordIndexViewModel
    {
        public int Id { get; set; }
        
        public int SollicitantId { get; set; }
        
        public Sollicitant Sollicitant { get; set; }
        
        [Display(Name="Naam")]
        public string VolledigeNaam { get; set; }
       
        public int SchoolId { get; set; }

        public Scholen School { get; set; }

        [Display(Name = "Startdatum")]
        public DateTime StartDatum { get; set; }

        [Display(Name = "Einddatum")]
        public DateTime Einddatum { get; set; }
    }
}
