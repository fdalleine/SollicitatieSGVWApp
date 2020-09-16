using SollicitatieSGVW.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Models
{
    public class TewerkstellingsRecordDetailViewModel
    {
        public int Id { get; set; }

        public int SollicitantId { get; set; }

        public Sollicitant Sollicitant { get; set; }

        [Display(Name = "Sollicitant")]
        public string VolledigeNaam { get; set; }

        public string SchoolNaam { get; set; }

        public int SchoolId { get; set; }

        public Scholen School { get; set; }

        [DataType(DataType.Date), Display(Name = "Startdatum")]
        public DateTime StartDatum { get; set; }

        [DataType(DataType.Date), Display(Name = "Einddatum")]
        public DateTime Einddatum { get; set; }

        public string Opmerking { get; set; }
    }
}
