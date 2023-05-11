using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehiculo vehiculo01 = new Vehiculo("", 150, "Rojo", "Joel", 93);

            


            Console.WriteLine("Clase Vehículo:\n\nPatente:" + vehiculo01.patente + "\nMotor: " + vehiculo01.motor +
                "\nColor: " + vehiculo01.color + "\nPropietario: " + vehiculo01.propietario + 
                "\nTipo de gasolina: " + vehiculo01.combustible + "\n");

            Console.ReadLine();


        }
    }
}
