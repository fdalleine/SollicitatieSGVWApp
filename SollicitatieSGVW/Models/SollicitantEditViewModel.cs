using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Models
{
    public class SollicitantEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Sollicitantnummer is vereist"),
            RegularExpression(@"^[A-Z] {3,3} [0-9] {3}$")]
        public string SollicitantNr { get; set; }

        [Required(ErrorMessage = "Voornaam is vereist"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z] [a-zA-A""'\s-]*$"), Display(Name = "Voornaam")]
        public string VoorNaam { get; set; }

        [Required(ErrorMessage = "Familienaam is vereist"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z] [a-zA-A""'\s-]*$"), Display(Name = "Familienaam")]
        public string FamilieNaam { get; set; }
        public string Geslacht { get; set; }

        [Required(ErrorMessage = "Geboortedatum is vereist"), DataType(DataType.Date), Display(Name = "Geboortedatum")]
        public DateTime GeboorteDatum { get; set; }

        [DataType(DataType.Date), Display(Name = "Datum van invullen")]
        public DateTime InvulDatum { get; set; }

        [Required(ErrorMessage = "Verplicht invullen vanaf wanneer je vrij bent"), DataType(DataType.Date), Display(Name = "Vrij vanaf...")]
        public DateTime DatumVrij { get; set; }

        [Required(ErrorMessage = "Email is vereist"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is vereist"), StringLength(50), Display(Name = "Telefoonnummer")]
        public string TelefoonNr { get; set; }

        [Required(ErrorMessage = "Adres is vereist"), StringLength(150)]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Postcode is vereist"), StringLength(50)]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Woonplaats is vereist"), StringLength(50)]
        public string WoonPlaats { get; set; }

        [Display(Name = "Rijksregisternummer"), RegularExpression(@"^\d{2} . \d{2} . \d{2} - \d{3} . \d{2} $")]
        public string RijksregisterNr { get; set; }

        [Required(ErrorMessage = "Diploma is vereist"), StringLength(50)]
        public string Dilpoma { get; set; }

        [Required(ErrorMessage = "Je vereiste vakken zijn vereist"), StringLength(50), Display(Name = "Vakken die je mag geven")]
        public string VereisteVakken { get; set; }

        [StringLength(200)]
        public string Motivatie { get; set; }

        [Display(Name = "CV toevoegen")]
        public IFormFile CvUrl { get; set; }
    }
}
