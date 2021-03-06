﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        [ForeignKey("Scholen")]
        public int SchoolId { get; set; }
        public Scholen School { get; set; }
        public string SchoolNaam { get; set; }

        public DateTime StartDatum { get; set; }
        public DateTime Einddatum { get; set; }

        [MaxLength(500)]
        public string Opmerking { get; set; }
    }
}
