using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Zalazar_Micaela_
{
    /* Ejercicio 3 */
    internal class Persona
    {
        //propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }

        /* Ejercicio 4 - añadir fecha de nacimiento*/
        public DateTime FechaNacimiento { get; set; }

        //Constructor por default
        public Persona()
        {

        }

        //Constructor con parametros para ejercicio 3
        public Persona(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        //Constructor con parametros para ejercicio 4
        public Persona(string nombre, string apellido, int dni, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
        }

        //Metodos
        public string GetNombreCompleto()
        {
            return Apellido + ", " + Nombre;
        }

        public int GetEdad()
        {
            DateTime fechaActual = DateTime.Now;
            return (fechaActual.Year -  FechaNacimiento.Year);
        }
    }
}
