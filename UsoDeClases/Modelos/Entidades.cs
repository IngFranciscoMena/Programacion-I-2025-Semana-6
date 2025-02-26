using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeClases.Modelos
{
    public class Persona
    {
        // Propiedades de la clase Persona
        public string nombres; 
        public string apellidos;
        public int edad;
        public DateTime fechaNacimiento; 
        public string documento; 
        public string telefono; 
        public string direccion; 
        public string email;

        // Constructor
        public Persona(string nombres, string apellidos, int edad, DateTime fechaNacimiento, string documento, string telefono
            , string direccion, string email)
        {
                    this.nombres = nombres;
                    this.apellidos = apellidos;
                    this.edad = edad;
                    this.fechaNacimiento = fechaNacimiento;
                    this.documento = documento;
                    this.telefono = telefono;
                    this.direccion = direccion;
                    this.email = email;
        }

        // Métodos
        public string MostrarDatos()
        {
            return $"Nombre: {this.nombres}\nApellidos: {this.apellidos}\nDocumento: {this.documento}\nEdad: {this.edad}\nEmail: {this.email}\nTelefono: {this.telefono}\nDireccion: {this.direccion}\n";
        }
    }


}
