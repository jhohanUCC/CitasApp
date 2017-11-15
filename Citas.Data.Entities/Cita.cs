using Citas.Date.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Data.Entities
{
    public class Cita : ICita
    {
        public int IdCita { get; set; }
        public string IdMedico { get; set; }
        public string IdPaciente { get; set; }
        public DateTime Fecha_Cita { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        public TimeSpan Hora { get; set; }
    }
}
