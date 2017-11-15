using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Date.Interfaces
{
    public interface IHistoriaClinica
    {
        int IdHistoriaClinica { get; set; }
        string IdPaciente { get; set; }
        DateTime FechaApertura { get; set; }
        DateTime FechaUltimaCita { get; set; }
        bool Estado { get; set; }
    }
}
