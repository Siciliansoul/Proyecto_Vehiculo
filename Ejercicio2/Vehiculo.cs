using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Vehiculo
    {
        #region atributos privados

        private string Patente;
        private int Motor;
        private string Color;
        private string Propietario;
        private int Combustible;

        #endregion

        #region Constructores
        public Vehiculo(string Patente, int Motor, string Color, string Propietario, int Combustible) {

                if (Patente.Length == 0)
                {

                    throw new ArgumentNullException(patente, "No puede ser nula la patente");

                }
                else { 

                    this.Patente = Patente;

                }

                if (Motor > 50 && Motor < 10000) {
                
                this.Motor = Motor;
                }
                else
                {
                throw new ArgumentOutOfRangeException("MOTOR:", motor, "El motor debe ser superior a 50 y menor a 10000");
                }

                if (Color.Length.Equals(0))
                {
                    throw new ArgumentNullException(patente, "Debe asignar un color");
                }
                else {
                    this.Color = Color;
                }

                this.Propietario = Propietario;
                this.Combustible = Combustible;

        }

        public Vehiculo(string Patente, int Motor, string Color, int Combustible)
        {

            if (Patente.Length == 0)
            {

                throw new ArgumentNullException(patente, "No puede ser nula la patente");

            }
            else
            {

                this.Patente = Patente;

            }

            if (Motor > 50 && Motor < 10000)
            {

                this.Motor = Motor;
            }
            else
            {
                throw new ArgumentOutOfRangeException("MOTOR:", motor, "El motor debe ser superior a 50 y menor a 10000");
            }

            if (Color.Length.Equals(0))
            {
                throw new ArgumentNullException(patente, "Debe asignar un color");
            }
            else
            {
                this.Color = Color;
            }

            this.Combustible = Combustible;

        }

        public Vehiculo(string Patente, int Motor, string Color)
        {

            if (Patente.Length == 0)
            {

                throw new ArgumentNullException(patente, "No puede ser nula la patente");

            }
            else
            {

                this.Patente = Patente;

            }

            if (Motor > 50 && Motor < 10000)
            {

                this.Motor = Motor;
            }
            else
            {
                throw new ArgumentOutOfRangeException("MOTOR:", motor, "El motor debe ser superior a 50 y menor a 10000");
            }

            if (Color.Length.Equals(0))
            {
                throw new ArgumentNullException(patente, "Debe asignar un color");
            }
            else
            {
                this.Color = Color;
            }     
        }

        #endregion

        #region propiedades o atributos públicos

        public string patente { get { return Patente; } }
        public int motor { get { return Motor; } set { motor = value; } }
        public string color { get { return Color; } set { color = value; } }
        public string propietario { get { return Propietario; } set { propietario = value; } }
        public int combustible { get { return Combustible; } set { combustible = value; } }

        #endregion

    }
}

