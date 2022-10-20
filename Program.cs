using System;
namespace ejercicio1
{
    class Escuela {
        public string nombre;
        public string direccion;
        public int anio;
        public string director;
        
        public void timbrar(){
            //todo
            Console.Beep(2000,3000);
        }
    }
    class ejercicio1 {
        static void Main(string[] args){
            var miEscuela = new Escuela();
            miEscuela.nombre = "Dr. Isidro Ayora Cueva";
            miEscuela.direccion = "Isidro Ayora";
            miEscuela.anio = 1980;
            miEscuela.director = "Raul Lara";
            Console.WriteLine($"La Colegio es {miEscuela.nombre} la direccion es {miEscuela.direccion} fue fundada en {miEscuela.anio} y el director es {miEscuela.director}");
            Console.WriteLine("Timbre");
            miEscuela.timbrar();
        }
    }
}
