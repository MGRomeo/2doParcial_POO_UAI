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
        public decimal ImporteRecargo(Cuota pCuota)
        {
            // $100 de recargo por dia de retraso en el pago
            decimal recargo = 100;
            Recargo = 0;
            TimeSpan dias = pCuota.Fecha_vencimiento - pCuota.Fecha_inicio.AddMonths(1);
            if (int.Parse(dias.Days.ToString()) > 0)
            {
                Recargo = recargo * int.Parse(dias.Days.ToString());
            }
            return Recargo;
        }

        public object Clone()
        {
           return this.MemberwiseClone();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
