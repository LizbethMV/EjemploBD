using Ejercicio1.mibd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Departamentos
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }

    }
}
