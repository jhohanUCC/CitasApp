using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Date.Interfaces
{
    public interface IEntidadPrestadoraSalud
    {
        int IdEntidadPrestadoraSalud { get; set; }
        string Nombre { get; set; }
        string Telefono { get; set; }
        string Direccion { get; set; }
        bool Estado { get; set; }
    }
}
