using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Date.Interfaces
{
    public interface IEspecialidad
    {
        int IdEspecialidad { get; set; }
        string Descripcion { get; set; }
        bool Estado { get; set; }
    }
}
