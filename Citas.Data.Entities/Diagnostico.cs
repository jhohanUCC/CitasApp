using Citas.Date.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Data.Entities
{
    public class Diagnostico : IDiagnostico
    {
        int IDiagnostico.IdDiagnostico { get; set; }
        int IDiagnostico.IdHistoriaClinica { get; set; }
        DateTime IDiagnostico.FechaEmision { get; set; }
        string IDiagnostico.Observacion { get; set; }
        bool IDiagnostico.Estado { get; set; }
    }
}
