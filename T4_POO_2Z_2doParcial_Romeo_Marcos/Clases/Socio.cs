using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_POO_2Z_2doParcial_Romeo_Marcos
{
    public abstract class Socio: ICloneable, IDisposable
    {
        public string Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public decimal Recargo { get; set; }

        public Socio() { }
        public Socio(string pLegajo, string pApellido, string pNombre)
        {
            Legajo = pLegajo;
            Apellido = pApellido;
            Nombre = pNombre;
        }
        public abstract decimal ImporteRecargo(Cuota pCuota);
        

        public object Clone()
        {
           return this.MemberwiseClone();
        }

        public void Dispose()
        {
        }
    }
}
