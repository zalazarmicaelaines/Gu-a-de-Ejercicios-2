using Clase3_Zalazar_Micaela_;
using System;

namespace Clase1y2
{
    class Program //Zalazar Micaela 
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 ya se realizo en la guia anterior

            //Ejercicio 2 //
            Cuadrado cuadrado = new Cuadrado(10,30);
            Console.WriteLine("El área resultante del cuadrado, cuya base es " + cuadrado.GetBase() + " y cuya altura es " + cuadrado.GetAltura() + " --> "+cuadrado.GetArea());

            //Ejercicio 3 //
            Persona persona = new Persona("Juan","Perez", 41038389);
            Console.WriteLine("\nLa persona cargada es " + persona.GetNombreCompleto());

            //Ejercicio 4 //
            DateTime fechaNac= new DateTime(2000, 4, 11, 15, 0, 0);
            Persona persona2 = new Persona("\nJuan", "Perez", 41038389, fechaNac);
            Console.WriteLine("La persona cargada es " + persona.GetNombreCompleto());
            Console.WriteLine(persona.Nombre + " tiene " + persona.GetEdad() + " años \n");

            //Ejercicio 5 //
            Auto auto = new Auto("Logan", "Renault", "Gris");
            auto.informarEstadoAuto();
            auto.cambiarEstadoMotor();
            auto.informarEstadoAuto();

            //Ejercicio 6 y 7 //
            Mascota mascota = new Mascota("Sol", "perro", 0);
            Console.WriteLine("\nMi mascota se llama " + mascota.Nombre + ", es un " + mascota.Tipo + " y tiene " + mascota.Energia + "% de energia en este momento");
            mascota.Alimentar();
            mascota.Alimentar();
            Console.WriteLine("Se alimento 2 veces a  " + mascota.Nombre + ", y ahora tiene " + mascota.Energia + "% de energia");
            mascota.Correr();
            mascota.Alimentar();
            Console.WriteLine(mascota.Nombre + " corrio una vez y se volvio a alimentar una vez mas , y ahora tiene " + mascota.Energia + "% de energia en este momento\n");

            //Ejercicio 8 //
            Smartphone telefono = new Smartphone("Motorola", "E50", "Gris");
            telefono.informarEstadoSmart();
            telefono.OnOffSmart();
            while (telefono.Volumen < 80)
            {
                telefono.SubirVolumen();
            }
            while (telefono.Brillo > 20)
            {
                telefono.BajarBrillo();
            }
            telefono.informarEstadoSmart();
        }
    }
}
