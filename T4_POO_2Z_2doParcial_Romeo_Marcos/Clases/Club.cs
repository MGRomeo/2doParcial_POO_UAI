using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static T4_POO_2Z_2doParcial_Romeo_Marcos.Form1;

namespace T4_POO_2Z_2doParcial_Romeo_Marcos
{
    public class Club
    {
        List<Socio> ListaSocios;
        List<Cuota> ListaCuotasPendientes;
        List<Cuota> ListaCuotasPagas;


        public Club()
        {   //Todo: tambien borrar esto al finalizar las pruebas
            ListaCuotasPendientes = new List<Cuota>();
            ListaCuotasPagas = new List<Cuota>();
            ListaSocios = new List<Socio>();
            ListaSocios.AddRange(new Socio[] { new Socio_Especial() { Legajo = "111", Apellido = "Martinez", Nombre = "Ana", }, 
                                               new Socio_Normal() { Legajo = "123", Apellido = "Garcia", Nombre = "Martin" },
                                               new Socio_Especial() { Legajo = "222", Apellido = "Fernandez", Nombre = "Jorge" }, 
                                              });
        }

        public void CargarSocio(Socio pSocio)
        {
            ListaSocios.Add(pSocio);
        }

        public void BorrarSocio(Socio pSocio)
        {
            ListaSocios.Remove(pSocio);

        }

        public Socio ModificarSocio(Socio pSocio)
        {
            // busco el socio pasado por parametro y devuelvo el que se encuentra en la lista
            Socio s = ListaSocios.Find(x => x.Legajo == pSocio.Legajo);
            return s;
        }

        public void CargarCuotaIndividual(Cuota pCuota)
        {
            Socio clon = (Socio)pCuota.Socio.Clone();
            clon.ImporteRecargo(pCuota);
            pCuota.Socio = clon;
            ListaCuotasPendientes.Add(pCuota);
        }

        public void CargarCuotaGeneral(Cuota pCuota)
        {
            foreach (var s in ListaSocios)
            {
                if (ValidaCuota(s))
                {
                    Cuota c = (Cuota)pCuota.Clone();
                    c.Socio = s;
                    Socio clon = (Socio)c.Socio.Clone();
                    clon.ImporteRecargo(c);
                    c.Socio = clon;
                    ListaCuotasPendientes.Add(c);
                }
                else
                {
                    MensajeExcesoCuota(s);
                }
            }
        }

        public bool ValidaCuota(Socio pSocio)
        {
            int cont = 0;
            foreach (var c in MostrarCuotasPendientes())
            {
                if (c.Socio.Legajo == pSocio.Legajo)
                {
                    cont++;
                    if (cont == 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void BorrarCuota(string pLegajo, int pCodigo)
        {
            var aux = ListaCuotasPendientes.Find(x => x.Socio.Legajo == pLegajo && x.Codigo == pCodigo);
            ListaCuotasPagas.Add(aux);
            ListaCuotasPendientes.Remove(aux);
        }

        public void ModificarSocioEnCuota(Socio pSocio,Socio pModifica)
        {

            Cuota existe = ListaCuotasPendientes.Find(x => x.Socio.Legajo == pSocio.Legajo);
            existe.Socio.Legajo = pModifica.Legajo;
            existe.Socio.Nombre= pModifica.Nombre;
            existe.Socio.Apellido= pModifica.Apellido;
        }

        public List<Socio> MostrarSocios()
        {
            List<Socio> aux = ListaSocios;
            return aux;
        }

        public List<Cuota> MostrarCuotasPendientes()
        {
            List<Cuota> aux = ListaCuotasPendientes.ToList();
            return aux;
        }
        public List<Cuota> MostrarCuotasPagas()
        {
            List<Cuota> aux = ListaCuotasPagas.ToList();
            return aux;
        }
        public void MensajeExcesoCuota(Socio pSocio)
        {
            MessageBox.Show($"El socio; {pSocio.Apellido}, {pSocio.Nombre} posee 2 cuotas sin pagar, no se genera cuota para esta persona", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
