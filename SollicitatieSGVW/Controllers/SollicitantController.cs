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
        private readonly HostingEnvironment _hostingEnvironment;
        public SollicitantController( ISollicitantService sollicitantService, HostingEnvironment hostingEnvironment)
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
                    Motivatie = model.Motivatie,
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
    }
}
