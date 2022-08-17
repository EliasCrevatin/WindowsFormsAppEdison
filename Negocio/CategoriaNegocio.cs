using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<catergoria> listar()
        {
            List<catergoria> lista = new List<catergoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Tipo from CATEGORIA");
                datos.EjecutarConsulta();

                while (datos.Lector.Read())
                {
                    catergoria aux = new catergoria();
                    aux.ID = (int)datos.Lector["Id"];
                    aux.Tipo = (string)datos.Lector["Tipo"];

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

