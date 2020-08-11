using Microsoft.AspNetCore.Mvc.Rendering;
using SollicitatieSGVW.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SollicitatieSGVW.Services
{
    public interface ISollicitantService
    {
        Task CreateAsync(Sollicitant newSollicitant);
        Sollicitant GetById(int sollicitantId);
        Task UpdateAsync(Sollicitant sollicitant);
        Task UpdateAsync(int id);
        Task Delete(int sollicitantId);
        IEnumerable<Sollicitant> GetAll();
        IEnumerable<SelectListItem> GetAllSollicitantenForTewerkstelling();
    }
}
