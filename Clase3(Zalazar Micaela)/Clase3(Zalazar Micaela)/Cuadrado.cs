using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Zalazar_Micaela_
{
    /* Ejercicio 2 */
    public class Cuadrado
    {
        //propiedades
        public float Base { get; set; }
        public float Altura { get; set; }

        //Constructor por default
        public Cuadrado()
        {

        }

        //Constructor con parametros
        public Cuadrado (float basee, float altura)
        {
            Altura = altura;
            Base = basee;
        }

        //Metodos
        public float GetBase()
        {
            return Base;
        }

        public float GetAltura()
        {
            return Altura;
        }

        public float GetArea()
        {
            return Base * Altura;
        }
        
    }
}
