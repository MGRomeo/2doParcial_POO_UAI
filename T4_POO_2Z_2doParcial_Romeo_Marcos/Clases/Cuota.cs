using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_POO_2Z_2doParcial_Romeo_Marcos
{
    public class Cuota:ICloneable
    {
        public int Codigo { get; set; }
        public int Importe { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public Socio Socio { get; set; }

        public Cuota(int pCodigo,int pImporte, Socio pSocio, DateTime pVencimiento) 
        {
            // El parametro pDefecto se crea a fines de prueba
            Codigo= pCodigo;
            Importe= pImporte;
            Socio= pSocio;
            Fecha_inicio = DateTime.Now.Date;
            Fecha_vencimiento = pVencimiento /*Fecha_inicio.AddMonths(1)*/;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
