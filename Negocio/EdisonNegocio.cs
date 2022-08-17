using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;


namespace Negocio
{
    public class EdisonNegocio
    {
        public List<Impulsor> listar()
        {
            List<Impulsor> lista = new List<Impulsor>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=master; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select  Nombre, Codigo, Diam_Exterior, Eje, Anclaje, URL_Imagen, Tipo from IMPULSORES I, CATEGORIA C where I.ID = C.ID";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Impulsor aux = new Impulsor();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.DiametroExterior = (int)lector["Diam_Exterior"];
                    aux.Eje = (int)lector["Eje"];
                    aux.Anclaje = (string)lector["Anclaje"];
                    aux.UrlImagen = (string)lector["URL_Imagen"];
                    aux.Tipo = new catergoria();
                    aux.Tipo.Tipo = (string)lector["Tipo"];


                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Agregar(Impulsor nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("insert into IMPULSORES (ID, Nombre, Codigo, Diam_Exterior, Eje, Anclaje) values (" + nuevo.ID + ", '" + nuevo.Nombre + "', '" + nuevo.Codigo + "', 1, @IDTipo)");
            datos.setearParametros("@IDTipo", nuevo.Tipo.ID);
            datos.EjecutarConsulta();
        }
    }
}
