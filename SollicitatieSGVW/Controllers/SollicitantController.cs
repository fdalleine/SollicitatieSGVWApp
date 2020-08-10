using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using SollicitatieSGVW.Entity;
using SollicitatieSGVW.Models;
using SollicitatieSGVW.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Controllers
{
    public class SollicitantController : Controller
    {
        private readonly ISollicitantService _sollicitantService;
        private readonly IHostingEnvironment _hostingEnvironment;
        public SollicitantController( ISollicitantService sollicitantService, IHostingEnvironment hostingEnvironment)
        {
            _sollicitantService = sollicitantService;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            var sollicitanten = _sollicitantService.GetAll().Select(sollicitant => new SollicitantIndexViewModel
            {
                Id = sollicitant.Id,
                SollicitantNr = sollicitant.SollicitantNr,
                VolledigeNaam = sollicitant.VolledigeNaam,
                Email = sollicitant.Email,
                Geslacht = sollicitant.Geslacht,
                GeboorteDatum = sollicitant.GeboorteDatum,
                DatumVrij = sollicitant.DatumVrij,
                Woonplaats = sollicitant.WoonPlaats,
                VereisteVakken = sollicitant.VereisteVakken
            }).ToList();
            return View(sollicitanten);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new SollicitantCreateViewModel();
            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SollicitantCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sollicitant = new Sollicitant
                {
                    Id = model.Id,
                    SollicitantNr = model.SollicitantNr,
                    VoorNaam = model.VoorNaam,
                    FamilieNaam = model.FamilieNaam,
                    VolledigeNaam = model.VolledigeNaam,
                    Geslacht = model.Geslacht,
                    GeboorteDatum = model.GeboorteDatum,
                    InvulDatum = model.InvulDatum,
                    DatumVrij = model.DatumVrij,
                    Email = model.Email,
                    TelefoonNr = model.TelefoonNr,
                    Adres = model.Adres,
                    PostCode = model.PostCode,
                    WoonPlaats = model.WoonPlaats,
                    RijksregisterNr = model.RijksregisterNr,
                    Dilpoma = model.Dilpoma,
                    VereisteVakken = model.VereisteVakken,
                    Motivatie = model.Motivatie
                };
                if (model.CvUrl != null && model.CvUrl.Length > 0)
                {
                    var uploadDir = @"images/sollicitant";
                    var fileName = Path.GetFileNameWithoutExtension(model.CvUrl.FileName);
                    var extension = Path.GetExtension(model.CvUrl.FileName);
                    var contentRootPath = _hostingEnvironment.ContentRootPath;
                    fileName = DateTime.UtcNow.ToString("yyyymmssfff") + fileName + extension;
                    var path = Path.Combine(contentRootPath, uploadDir, fileName);
                    await model.CvUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                    sollicitant.CvUrl = "/" + uploadDir + "/" + fileName;
                }
                await _sollicitantService.CreateAsync(sollicitant);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var sollicitant = _sollicitantService.GetById(id);
            if (sollicitant == null)
            {
                return NotFound();
            }
            var model = new SollicitantEditViewModel()
            {
                Id = sollicitant.Id,
                SollicitantNr = sollicitant.SollicitantNr,
                VoorNaam = sollicitant.VoorNaam,
                FamilieNaam = sollicitant.FamilieNaam,
                Geslacht = sollicitant.Geslacht,
                GeboorteDatum = sollicitant.GeboorteDatum,
                InvulDatum = sollicitant.InvulDatum,
                DatumVrij = sollicitant.DatumVrij,
                Email = sollicitant.Email,
                TelefoonNr = sollicitant.TelefoonNr,
                Adres = sollicitant.Adres,
                PostCode = sollicitant.PostCode,
                WoonPlaats = sollicitant.WoonPlaats,
                RijksregisterNr = sollicitant.RijksregisterNr,
                Dilpoma = sollicitant.Dilpoma,
                VereisteVakken = sollicitant.VereisteVakken,
                Motivatie = sollicitant.Motivatie
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (SollicitantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var sollicitant = _sollicitantService.GetById(model.Id);
                if (sollicitant == null)
                {
                    return NotFound();
                }
                sollicitant.SollicitantNr = model.SollicitantNr;
                sollicitant.VoorNaam = model.VoorNaam;
                sollicitant.FamilieNaam = model.FamilieNaam;
                sollicitant.Geslacht = model.Geslacht;
                sollicitant.GeboorteDatum = model.GeboorteDatum;
                sollicitant.InvulDatum = model.InvulDatum;
                sollicitant.DatumVrij = model.DatumVrij;
                sollicitant.Email = model.Email;
                sollicitant.TelefoonNr = model.TelefoonNr;
                sollicitant.Adres = model.Adres;
                sollicitant.PostCode = model.PostCode;
                sollicitant.WoonPlaats = model.WoonPlaats;
                sollicitant.RijksregisterNr = model.RijksregisterNr;
                sollicitant.Dilpoma = model.Dilpoma;
                sollicitant.VereisteVakken = model.VereisteVakken;
                sollicitant.Motivatie = model.Motivatie;
                if (model.CvUrl != null && model.CvUrl.Length > 0)
                {
                    var uploadDir = @"images/sollicitant";
                    var fileName = Path.GetFileNameWithoutExtension(model.CvUrl.FileName);
                    var extension = Path.GetExtension(model.CvUrl.FileName);
                    var contentRootPath = _hostingEnvironment.ContentRootPath;
                    fileName = DateTime.UtcNow.ToString("yyyymmssfff") + fileName + extension;
                    var path = Path.Combine(contentRootPath, uploadDir, fileName);
                    await model.CvUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                    sollicitant.CvUrl = "/" + uploadDir + "/" + fileName;
                }
                await _sollicitantService.UpdateAsync(sollicitant);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var sollicitant = _sollicitantService.GetById(id);
            if (sollicitant == null)
            {
                return NotFound();
            }
            SollicitantDetailViewModel model = new SollicitantDetailViewModel()
            {
                Id = sollicitant.Id,
                SollicitantNr = sollicitant.SollicitantNr,
                VolledigeNaam = sollicitant.VolledigeNaam,
                Geslacht = sollicitant.Geslacht,
                GeboorteDatum = sollicitant.GeboorteDatum,
                InvulDatum = sollicitant.InvulDatum,
                DatumVrij = sollicitant.DatumVrij,
                Email = sollicitant.Email,
                TelefoonNr = sollicitant.TelefoonNr,
                Adres = sollicitant.Adres,
                PostCode = sollicitant.PostCode,
                WoonPlaats = sollicitant.WoonPlaats,
                RijksregisterNr = sollicitant.RijksregisterNr,
                Dilpoma = sollicitant.Dilpoma,
                VereisteVakken = sollicitant.VereisteVakken,
                Motivatie = sollicitant.Motivatie,
                CvUrl = sollicitant.CvUrl
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sollicitant = _sollicitantService.GetById(id);
            if (sollicitant == null)
            {
                return NotFound();
            }
            var model = new SollicitantDeleteViewModel()
            {
                Id = sollicitant.Id,
                VolledigeNaam = sollicitant.VolledigeNaam
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(SollicitantDeleteViewModel model)
        {
            await _sollicitantService.Delete(model.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
