using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TurnoNegocio
    {
        public List<Turno> listar()
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();
            

            try
            {
                datos.setearConsulta("select T.Id, T.Fecha, T.Cliente, S.Corte , V.Valor, A.Nombre from AUTOR A, SERVICIO S, SERVICIO V, TURNOS T where T.IdServicio = S.Id and T.IdAutor = A.Id and T.IdServicio = V.Id order by Fecha asc");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Cliente = (string)datos.Lector["Cliente"];
                    aux.Servicio = new Servicio();
                    aux.Servicio.Id = (int)datos.Lector["Id"];
                    aux.Servicio.Corte = (string)datos.Lector["Corte"];
                    aux.Servicio.Valor = (decimal)datos.Lector["Valor"];
                    aux.Valor = new Servicio();
                    aux.Valor.Id = (int)datos.Lector["Id"];
                    aux.Valor.Valor = (decimal)datos.Lector["Valor"];
                    aux.Valor.Corte = (string)datos.Lector["Corte"];
                    aux.Autor = new Autor();
                    aux.Autor.Id = (int)datos.Lector["Id"];
                    aux.Autor.Nombre = (string)datos.Lector["Nombre"];
                    //aux.Importe = (decimal)datos.Lector["Importe"];

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

        public void agregar(Turno nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into TURNOS(Fecha,Cliente,IdServicio,IdAutor,IdValor) values (@Fecha,@Cliente,@IdServicio,@IdAutor,@IdValor)");
                datos.setearParametro("@Fecha", nuevo.Fecha);
                datos.setearParametro("@Cliente", nuevo.Cliente);
                datos.setearParametro("@IdServicio", nuevo.Servicio.Id);
                datos.setearParametro("@IdAutor", nuevo.Autor.Id);
                datos.setearParametro("@IdValor", nuevo.Valor.Id);
                //datos.setearParametro("@Importe", nuevo.Importe);
                datos.ejecutarAccion();
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

        public void modificar(Turno turno)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update TURNOS set Fecha = @Fecha, Cliente = @Cliente, IdServicio = @IdServicio, IdAutor = @IdAutor, IdValor = @IdValor where Id = @Id");
                datos.setearParametro("@Fecha", turno.Fecha);
                datos.setearParametro("@Cliente", turno.Cliente);
                datos.setearParametro("@IdServicio", turno.Servicio.Id);
                datos.setearParametro("@IdAutor", turno.Autor.Id);
                datos.setearParametro("@IdValor", turno.Valor.Id);
                //datos.setearParametro("@Importe", turno.Importe);
                datos.setearParametro("@Id", turno.Id);
                datos.ejecutarAccion();
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

        public void eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from TURNOS where Id = @Id");
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Turno> listarHoy()
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select T.Id, T.Fecha, T.Cliente, S.Corte , V.Valor, A.Nombre from AUTOR A, SERVICIO S, SERVICIO V, TURNOS T where T.IdServicio = S.Id and T.IdAutor = A.Id and T.IdServicio = V.Id  and DATEDIFF(day,FECHA,GETDATE())=0 order by Fecha asc");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Cliente = (string)datos.Lector["Cliente"];
                    aux.Servicio = new Servicio();
                    aux.Servicio.Id = (int)datos.Lector["Id"];
                    aux.Servicio.Corte = (string)datos.Lector["Corte"];
                    aux.Servicio.Valor = (decimal)datos.Lector["Valor"];
                    aux.Valor = new Servicio();
                    aux.Valor.Id = (int)datos.Lector["Id"];
                    aux.Valor.Valor = (decimal)datos.Lector["Valor"];
                    aux.Valor.Corte = (string)datos.Lector["Corte"];
                    aux.Autor = new Autor();
                    aux.Autor.Id = (int)datos.Lector["Id"];
                    aux.Autor.Nombre = (string)datos.Lector["Nombre"];
                    //aux.Importe = (decimal)datos.Lector["Importe"];

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

        public List<Turno> listarSemana()
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select T.Id, T.Fecha, T.Cliente, S.Corte , V.Valor, A.Nombre from AUTOR A, SERVICIO S, SERVICIO V, TURNOS T where T.IdServicio = S.Id and T.IdAutor = A.Id and T.IdServicio = V.Id and t.Fecha >= DATEADD(wk,(DATEDIFF(wk,0,GETDATE()-1)),0) and t.Fecha <= DATEADD(ms,-3,(DATEADD(wk,DATEDIFF(wk,0,GETDATE()-1),7))) ORDER BY T.Fecha ASC ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Cliente = (string)datos.Lector["Cliente"];
                    aux.Servicio = new Servicio();
                    aux.Servicio.Id = (int)datos.Lector["Id"];
                    aux.Servicio.Corte = (string)datos.Lector["Corte"];
                    aux.Servicio.Valor = (decimal)datos.Lector["Valor"];
                    aux.Valor = new Servicio();
                    aux.Valor.Id = (int)datos.Lector["Id"];
                    aux.Valor.Valor = (decimal)datos.Lector["Valor"];
                    aux.Valor.Corte = (string)datos.Lector["Corte"];
                    aux.Autor = new Autor();
                    aux.Autor.Id = (int)datos.Lector["Id"];
                    aux.Autor.Nombre = (string)datos.Lector["Nombre"];
                    //aux.Importe = (decimal)datos.Lector["Importe"];

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
