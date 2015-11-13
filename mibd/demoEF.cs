using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.mibd
{
    public class demoEF : DbContext
    { //Empleado es el nombre de la clase y el "Empleados" nos referiremos a los objetos"
       public DbSet<Empleado> Empleados { get; set; }
    }
}
