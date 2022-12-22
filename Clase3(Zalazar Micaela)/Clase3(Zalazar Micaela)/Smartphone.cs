using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Zalazar_Micaela_
{
    /* Ejercicio 8 */
    internal class Smartphone
    {
        //propiedades
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public bool Encendido { get; set; }
        public bool Silencio { get; set; }
        public int Brillo { get; set; }
        public int Volumen { get; set; }

        //Constructor por default
        public Smartphone()
        {

        }

        //Constructor con parametros
        public Smartphone(string modelo, string marca, string color)
        {
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Encendido = true;
            Silencio = false;   
            Brillo = 50;
            Volumen = 50;
        }


        //Metodos
        public void OnOffSmart()
        {
            if (Encendido)
            {
                Encendido = false;
            }
            else
            {
                Encendido = true;
            }
        }

        public void SilenciarSmart()
        {
            if (Silencio)
            {
                Silencio = false;
            }
            else
            {
                Silencio = true;
            }
        }

        public void SubirVolumen()
        {
            if (Volumen < 100)
            {
                Volumen++;
            }
        }

        public void BajarVolumen()
        {
            if (Volumen > 0)
            {
                Volumen--;
            }
        }

        public void SubirBrillo()
        {
            if (Brillo < 100)
            {
                Brillo++;
            }
        }

        public void BajarBrillo()
        {
            if (Brillo > 0)
            {
                Brillo--;
            }
        }

        public void informarEstadoSmart()
        {
            string encendido, silencio;
            if (Encendido)
            {
                encendido = "SI";
            }else
            {
                encendido = "NO";
            }
            if (Silencio)
            {
                silencio = "SI";
            }
            else
            {
                silencio = "NO";
            }
            Console.WriteLine("Smart " + Marca + " " + Modelo + " - color " + Color + ": \n\t Encendido : " + encendido + "\n\t Silenciado: " + encendido + "\n\t Volumen : " + Volumen + "% \n\t Brillo: " + Brillo + "%");
        }
    }
}
