using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Controladora; 

namespace Dominio
{
    public class CN_Alumnos
    {
        private Con_Alumnos AlumnoCD = new Con_Alumnos();

        //mostrar alumno 
        public DataTable MostrarAlumno()
        {
            DataTable tabla = new DataTable();
            tabla = AlumnoCD.Mostrar();
            return tabla;
        }
        //listar alumno
        public DataTable ListarAlumnos()
        {
            return AlumnoCD.ListarAlumnos();
        }
        //agregar alumno
        public void InsertarAlumno (string Nombre, string apellido, string NumeroTelefono, string numAllegado, string DNI, string PagoCuota)
        {
            AlumnoCD.Insertar(Nombre, apellido, Convert.ToInt64(NumeroTelefono), Convert.ToInt64(numAllegado), Convert.ToInt64(DNI), PagoCuota);
        } 
        //modificar alumno
        public void ModificarAlumno (string Nombre, string apellido, string NumeroTelefono, string numAllegado, string DNI, string PagoCuota, int id)
        {
            AlumnoCD.Modificar(Nombre, apellido, Convert.ToInt64(NumeroTelefono), Convert.ToInt64(numAllegado), Convert.ToInt64(DNI), PagoCuota, id); 
        }
        //eliminar alumno
        public void EliminarAlumno (int id)
        {
            AlumnoCD.Eliminar(id); 
        }

  
            
    }
}
