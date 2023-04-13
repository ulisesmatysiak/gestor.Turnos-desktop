using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ServicioNegocio
    {
        public List<Servicio> listar()
        {
            List<Servicio> lista = new List<Servicio>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Corte from SERVICIO");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Servicio aux = new Servicio();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Corte = (string)datos.Lector["Corte"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
