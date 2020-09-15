using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RotativaCore;
using SollicitatieSGVW.Entity;
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
        private readonly ITewerkstellingService _tewerkstellingService;
        private readonly ISollicitantService _sollicitantService;
        public TewerkstellingController(ITewerkstellingService tewerkstellingService, ISollicitantService sollicitantService)
        {
            _tewerkstellingService = tewerkstellingService;
            _sollicitantService = sollicitantService;
        }

        [Authorize(Roles = "Admin, Directie, Secretariaat")]
        public IActionResult Index()
        {
            var tewerkstellingsRecord = _tewerkstellingService.GetAll().Select(tewerkstelling => new TewerkstellingsRecordIndexViewModel
            {
                Id = tewerkstelling.Id,
                SollicitantId = tewerkstelling.SollicitantId,
                Sollicitant = tewerkstelling.Sollicitant,
                VolledigeNaam = tewerkstelling.VolledigeNaam,
                SchoolNaam = tewerkstelling.SchoolNaam,
                SchoolId = tewerkstelling.SchoolId,
                School = tewerkstelling.School,
                StartDatum = tewerkstelling.StartDatum,
                Einddatum = tewerkstelling.Einddatum
            }) ;
            return View(tewerkstellingsRecord);
        }

        [Authorize(Roles = "Admin, Directie")]
        public IActionResult Create()
        {
            ViewBag.sollicitanten = _sollicitantService.GetAllSollicitantenForTewerkstelling();
            ViewBag.scholen = _tewerkstellingService.GetAllScholen();
            var model = new TewerkstellingsRecordCreateViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Directie")]
        public async Task<IActionResult> Create( TewerkstellingsRecordCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var tewerkstellingrecord = new TewerkstellingsRecord()
                {
                    Id = model.Id,
                    SollicitantId = model.SollicitantId,
                    VolledigeNaam = _sollicitantService.GetById(model.SollicitantId).VolledigeNaam,
                    SchoolId = model.SchoolId,
                    School = model.School,
                    StartDatum = model.StartDatum,
                    Einddatum = model.Einddatum,
                    Opmerking = model.Opmerking
                };
                await _tewerkstellingService.CreateAsync(tewerkstellingrecord);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.sollicitanten = _sollicitantService.GetAllSollicitantenForTewerkstelling();
            ViewBag.scholen = _tewerkstellingService.GetAllScholen();
            return View();
        }

        [Authorize(Roles = "Admin, Directie")]
        public IActionResult Detail(int id)
        {
            var tewerkstellingsrecord = _tewerkstellingService.GetById(id);
            if(tewerkstellingsrecord == null)
            {
                return NotFound();
            }

            var model = new TewerkstellingsRecordDetailViewModel()
            {
                Id = tewerkstellingsrecord.Id,
                SollicitantId = tewerkstellingsrecord.SollicitantId,
                VolledigeNaam = tewerkstellingsrecord.VolledigeNaam,
                SchoolId = tewerkstellingsrecord.SchoolId,
                School = tewerkstellingsrecord.School,
                StartDatum = tewerkstellingsrecord.StartDatum,
                Einddatum = tewerkstellingsrecord.Einddatum,
                Opmerking = tewerkstellingsrecord.Opmerking
            };
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult DetailPdf(int id)
        {
            var tewerkstellingsrecord = _tewerkstellingService.GetById(id);
            if (tewerkstellingsrecord == null)
            {
                return NotFound();
            }

            var model = new TewerkstellingsRecordDetailViewModel()
            {
                Id = tewerkstellingsrecord.Id,
                SollicitantId = tewerkstellingsrecord.SollicitantId,
                VolledigeNaam = tewerkstellingsrecord.VolledigeNaam,
                SchoolId = tewerkstellingsrecord.SchoolId,
                School = tewerkstellingsrecord.School,
                StartDatum = tewerkstellingsrecord.StartDatum,
                Einddatum = tewerkstellingsrecord.Einddatum,
                Opmerking = tewerkstellingsrecord.Opmerking
            };
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Directie")]
        public IActionResult Edit(int id)
        {
            ViewBag.sollicitanten = _sollicitantService.GetAllSollicitantenForTewerkstelling();
            ViewBag.scholen = _tewerkstellingService.GetAllScholen();
            var tewerkstellingsrecord = _tewerkstellingService.GetById(id);
            if (tewerkstellingsrecord == null)
            {
                return NotFound();
            }
            var model = new TewerkstellingsRecordEditViewModel()
            {
                Id = tewerkstellingsrecord.Id,
                SollicitantId = tewerkstellingsrecord.SollicitantId,
                VolledigeNaam = tewerkstellingsrecord.VolledigeNaam,
                SchoolId = tewerkstellingsrecord.SchoolId,
                School = tewerkstellingsrecord.School,
                StartDatum = tewerkstellingsrecord.StartDatum,
                Einddatum = tewerkstellingsrecord.Einddatum,
                Opmerking = tewerkstellingsrecord.Opmerking
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Directie")]
        public async Task<IActionResult> Edit(TewerkstellingsRecordEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var tewerkstelling = _tewerkstellingService.GetById(model.Id);
                if (tewerkstelling == null)
                {
                    return NotFound();
                }
                tewerkstelling.SollicitantId = model.SollicitantId;
                tewerkstelling.VolledigeNaam = model.VolledigeNaam;
                tewerkstelling.SchoolId = model.SchoolId;
                tewerkstelling.School = model.School;
                tewerkstelling.StartDatum = model.StartDatum;
                tewerkstelling.Einddatum = model.Einddatum;
                tewerkstelling.Opmerking = model.Opmerking;
                await _tewerkstellingService.UpdateAsync(tewerkstelling);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.sollicitanten = _sollicitantService.GetAllSollicitantenForTewerkstelling();
            ViewBag.scholen = _tewerkstellingService.GetAllScholen();
            return View();
        }

        public IActionResult GeneratePdf(int id)
        {
            var tewerkstelling = new ActionAsPdf("DetailPdf", new { id = id })
            {
                FileName = "tewerkstelling.pdf"
            };
            return tewerkstelling;
        }
    }
}
