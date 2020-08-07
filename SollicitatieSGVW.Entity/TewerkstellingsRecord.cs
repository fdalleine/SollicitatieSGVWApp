using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SollicitatieSGVW.Entity
{
    public class TewerkstellingsRecord
    {
        public int Id { get; set; }
        [ForeignKey("Sollicitant")]
        public int SollicitantId { get; set; }
        public Sollicitant Sollicitant { get; set; }
        public string VolledigeNaam { get; set; }
        public Schoolkeuze School { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime Einddatum { get; set; }
    }
}
