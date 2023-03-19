using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_POO_2Z_2doParcial_Romeo_Marcos
{
    public class Cuota : ICloneable
    {
        public int Codigo { get; set; }
        public int Importe { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public decimal Total { get; set; }
        public Socio Socio { get; set; }

        public Cuota(int pCodigo, int pImporte, Socio pSocio, DateTime pVencimiento)
        {
            // El parametro pVencimiento se crea a fines de prueba
            Codigo = pCodigo;
            Importe = pImporte;
            Socio = pSocio;
            Fecha_inicio = DateTime.Now.Date;
            Fecha_vencimiento = pVencimiento; //en realidad sería => Fecha_vencimiento = Fecha_inicio.AddMonths(1);
            Total = Importe + Socio.Recargo;
        }

        public decimal CalculoTotal(Socio pSocio)
        {
            Total = Importe + pSocio.Recargo;
            return Total;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public class ImporteASC : IComparer<Cuota>
        {
            public int Compare(Cuota x, Cuota y)
            {
                return String.Compare((x.Importe).ToString(), y.Importe.ToString());
            }
        }
        public class ImporteDESC : IComparer<Cuota>
        {
            public int Compare(Cuota x, Cuota y)
            {
                return String.Compare((x.Importe).ToString(), y.Importe.ToString()) * -1;
            }
        }
    }
}
