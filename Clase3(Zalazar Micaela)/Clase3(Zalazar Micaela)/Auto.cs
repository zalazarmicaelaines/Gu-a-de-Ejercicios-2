using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3_Zalazar_Micaela_
{
    /* Ejercicio 5 */
    internal class Auto
    {
        //propiedades
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public bool Encendido { get; set; }
        public int Velocidad { get; set; }

        //Constructor por default
        public Auto()
        {

        }

        //Constructor con parametros para ejercicio 3
        public Auto(string modelo, string marca, string color, int velocidad)
        {
            Modelo = modelo;
            Marca = marca;
            Color = color;
            Encendido = true;
            Velocidad = 0;
        }


        //Metodos
        public void  cambiarEstadoMotor()
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
        
        public void informarEstadoAuto()
        {
            if (Encendido)
            {
                Console.WriteLine("El automovil " + Marca + " " + Modelo + " - color " + Color + " esta ENCENDIDO");
            }
            else
            {
                Console.WriteLine("El automovil " + Marca + " " + Modelo + " - color " + Color + " esta APAGADO");
            }
        }

        //Ejercicio 9
        public void Acelerar()
        {
            if (Velocidad < 90)
            {
                Velocidad = Velocidad + 10;
            }
            else
            {
                Velocidad = 100;
            }
        }

        public void ReducirVelocidad()
        {
            if (Encendido == false)
            {
                cambiarEstadoMotor();            
            }

            if (Velocidad > 20)
            {
                Velocidad = Velocidad - 20;
            }
        }
    }
}
