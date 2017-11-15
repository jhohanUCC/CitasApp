using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Date.Interfaces
{
    public interface ICita
    {
        int IdCita { get; set; }
        string IdMedico { get; set; }
        string IdPaciente { get; set; }
        DateTime Fecha_Cita { get; set; }
        string Observacion { get; set; }
        bool Estado { get; set; }
        TimeSpan Hora { get; set; }
    }
}
