using Microsoft.AspNetCore.Mvc;
using SollicitatieSGVW.Models;
using SollicitatieSGVW.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Controllers
{
    public class TewerkstellingController : Controller
    {
        private readonly ITewerkstellingService _tewerkstellingService
        public TewerkstellingController(ITewerkstellingService tewerkstellingService)
        {
            _tewerkstellingService = tewerkstellingService;
        }

        public IActionResult Index()
        {
            var tewerkstellingsRecord = _tewerkstellingService.GetAll().Select(tewerkstelling => new TewerkstellingsRecordIndexViewModel 
            {
                Id = tewerkstelling.Id,
                SollicitantId = tewerkstelling.SollicitantId,
                Sollicitant = tewerkstelling.Sollicitant,
                VolledigeNaam = tewerkstelling.VolledigeNaam,
                School = tewerkstelling.School,
                StartDatum = tewerkstelling.StartDatum,
                Einddatum = tewerkstelling.Einddatum
            });
            return View(tewerkstellingsRecord);
        }
    }
}
