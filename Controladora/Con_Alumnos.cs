using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_soporte.caché;
using System.Net;

namespace Controladora
{
    public class Con_Alumnos
    {
        private ConexiónASQL_JU_ conexion = new ConexiónASQL_JU_(); 

        SqlDataReader leer; 
        DataTable tabla = new DataTable(); 
        SqlCommand comando = new SqlCommand(); 
        Alumnos Alumnos = new Alumnos();

        public bool ModificarAl(string DNI)
        {
            using (var connection = conexion.AbrirConexion())
            {
                connection.Open(); 
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Alumnos where DNI=@DNI";
                    command.Parameters.AddWithValue("@DNI", DNI);
                    command.CommandType = CommandType.Text; 
                    SqlDataReader reader = command.ExecuteReader(); 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Alumnos.Nombre = reader.GetString(0); 
                            Alumnos.apellido = reader.GetString(1); 
                            Alumnos.NumeroTelefono = reader.GetInt64(2);
                            Alumnos.numAllegado = reader.GetInt64(3); 
                            Alumnos.DNI = reader.GetInt64(4);
                            Alumnos.PagoCuota = reader.GetString(5);
                            Alumnos.id = reader.GetInt32(6); 
                        }
                        return true; 

                    }
                    else { return false; }
                }
            }
        }


        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAlumnos";
            comando.CommandType = CommandType.StoredProcedure; 
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarAlumnos()
        {
            DataTable dataTable = new DataTable();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion.AbrirConexion();
                    comando.CommandText = "select Nombre, apellido, NumeroTelefono, numAllegado, DNI, PagoCuota, Id from Alumnos";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader resultado = comando.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        dataTable.Load(resultado);
                    }
                    conexion.CerrarConexion();
                    return dataTable;

                }
  
        }

        public void Insertar(string Nombre, string apellido, Int64 NumeroTelefono, Int64 numAllegado, Int64 DNI, string PagoCuota)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Alumnos values ('"+Nombre+"', '"+apellido+"', "+NumeroTelefono+", "+numAllegado+", "+DNI+", '"+PagoCuota+"')";
            comando.CommandType = CommandType.Text; 
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); 
        }

        public void Modificar(string Nombre, string apellido, Int64 NumeroTelefono, Int64 numAllegado, Int64 DNI, string PagoCuota, int id)
        {
            comando.Connection = conexion.AbrirConexion(); 
            comando.CommandText = "update Alumnos set Nombre = @nombre, apellido = @Apellido, NumeroTelefono = @numtelefono, numAllegado = @NumAllegado, DNI = @dni, PagoCuota = @pagocuota where id = @id";
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", apellido);
            comando.Parameters.AddWithValue("@numtelefono", NumeroTelefono);
            comando.Parameters.AddWithValue("@NumAllegado", numAllegado);
            comando.Parameters.AddWithValue("@dni", DNI);
            comando.Parameters.AddWithValue("@pagocuota", PagoCuota);
            comando.Parameters.AddWithValue("@id", id); 
            comando.CommandType = CommandType.Text; 
            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); 
        }

        public void Eliminar (int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DELETE from Alumnos where Id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
