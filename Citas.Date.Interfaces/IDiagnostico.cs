using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Date.Interfaces
{
    public interface IDiagnostico
    {
        int IdDiagnostico { get; set; }
        int IdHistoriaClinica { get; set; }
        DateTime FechaEmision { get; set; }
        string Observacion { get; set; }
        bool Estado { get; set; }
    }
}
