using Citas.Date.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Data.Entities
{
    public class AgendaMedico : IAgendaMedico
    {
        public int IdAgendaMedico { get ; set ; }
        public string IdMedico { get ; set ; }
        public TimeSpan HoraInicio { get ; set ; }
        public TimeSpan HoraFin { get ; set ; }
        public DateTime FechaInicio { get ; set ; }
        public DateTime FechaFin { get ; set ; }
        public bool Estado { get ; set ; }
    }
}
