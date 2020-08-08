using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Models
{
    public class SollicitantDetailViewModel
    {
        public int Id { get; set; }       
        public string SollicitantNr { get; set; }
        public string VolledigeNaam { get; set; }
        public string Geslacht { get; set; }        
        public DateTime GeboorteDatum { get; set; }
        public DateTime InvulDatum { get; set; }
        public DateTime DatumVrij { get; set; }        
        public string Email { get; set; }        
        public string TelefoonNr { get; set; }        
        public string Adres { get; set; }       
        public string PostCode { get; set; }        
        public string WoonPlaats { get; set; }
        public string RijksregisterNr { get; set; }        
        public string Dilpoma { get; set; }        
        public string VereisteVakken { get; set; }
        public string Motivatie { get; set; }
        public string CvUrl { get; set; }
    }
}
