using SollicitatieSGVW.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SollicitatieSGVW.Services
{
    public interface IScholenService
    {
        Scholen GetById(int schoolId);
    }
}
