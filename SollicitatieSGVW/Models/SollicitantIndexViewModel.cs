using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Models
{
    public class SollicitantIndexViewModel
    {
        public int Id { get; set; }
        public string SollicitantNr { get; set; }
        public string VolledigeNaam { get; set; }
        public string Email { get; set; }
        public string Geslacht { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public DateTime DatumVrij { get; set; }
        public string Woonplaats { get; set; }
        public string VereisteVakken { get; set; }
    }
}
