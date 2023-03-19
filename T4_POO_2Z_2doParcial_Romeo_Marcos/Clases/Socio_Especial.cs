using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_POO_2Z_2doParcial_Romeo_Marcos
{
    public class Socio_Especial : Socio
    {
        public Socio_Especial() { }
        public Socio_Especial(string pLegajo, string pApellido, string pNombre) : base(pLegajo, pApellido, pNombre)
        {
        }
        public override decimal ImporteRecargo(Cuota pCuota)
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
    }
}
