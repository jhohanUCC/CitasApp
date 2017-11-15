using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Date.Interfaces
{
    public interface IAgendaMedico
    {
        int IdAgendaMedico { get; set; }
        string IdMedico { get; set; }
        TimeSpan HoraInicio { get; set; }
        TimeSpan HoraFin { get; set; }
        DateTime FechaInicio { get; set; }
        DateTime FechaFin { get; set; }
        bool Estado { get; set; }
    }
}
