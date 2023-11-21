using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace Controladora
{
    public class ConexiónASQL_JU_
    {
        private SqlConnection conexion = new SqlConnection("Data Source = LAPTOP-DFLJOD9O; Initial Catalog = GymManagement; Integrated Security = True"); 

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion; 
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open) 
                conexion.Close();
                return conexion;
        }
    }
}
