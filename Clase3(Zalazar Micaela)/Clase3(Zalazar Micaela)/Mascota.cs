using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Zalazar_Micaela_
{
    /* Ejercicio 6 */
    internal class Mascota
    {
        //propiedades
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public int Energia { get; set; }
        

        //Constructor por default
        public Mascota()
        {

        }

        public Mascota(string nombre, string tipo, int energia)
        {
            Nombre = nombre;
            Tipo = tipo;
            Energia = energia;
        }


        //Metodos
        public void Alimentar()
        {
            if (Energia < 70)
            {
                Energia = Energia + 30;
            }else
            {
                Energia = 100;
            }
        }

        // Nuevo metodo para el ejercicio 7
        public void Correr()
        {
            if (Energia > 20)
            {
                Energia = Energia - 10;
            }
        }
    }
}
