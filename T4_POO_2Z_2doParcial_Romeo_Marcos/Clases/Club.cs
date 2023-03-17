using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_POO_2Z_2doParcial_Romeo_Marcos
{
    public class Club
    {
        List<Socio> ListaSocios;
        List<Cuota> ListaCuotas;

        public Club()
        {
            ListaCuotas = new List<Cuota>();
            ListaSocios = new List<Socio>();
            ListaSocios.AddRange(new Socio[] { new Socio_Especial() { Legajo = "111", Apellido = "Martinez", Nombre = "Ana" }, 
                                               new Socio_Especial() { Legajo = "123", Apellido = "Garcia", Nombre = "Martin" },
                                               new Socio_Especial() { Legajo = "222", Apellido = "Fernandez", Nombre = "Jorge" }, 
                                              });
        }

        public void CargarSocio(Socio pSocio)
        {
            ListaSocios.Add(pSocio);
        }
        public void CargarCuotaIndividual(Cuota pCuota)
        {
            Socio clon = (Socio)pCuota.Socio.Clone();
            clon.ImporteRecargo(pCuota);
            pCuota.Socio = clon;
            ListaCuotas.Add(pCuota);
        }
        public void CargarCuotaGeneral(Cuota pCuota)
        {
            foreach (var s in ListaSocios)
            {
                Cuota c = (Cuota)pCuota.Clone();
                c.Socio = s;
                Socio clon = (Socio)c.Socio.Clone();
                clon.ImporteRecargo(c);
                c.Socio = clon;
                ListaCuotas.Add(c);
            }
        }

        public List<Socio> MostrarSocios()
        {
            List<Socio> aux = ListaSocios;
            return aux;
        }
        public List<Cuota> MostrarCuotas()
        {
            List<Cuota> aux = ListaCuotas.ToList();
            return aux;
        }

    }
}
