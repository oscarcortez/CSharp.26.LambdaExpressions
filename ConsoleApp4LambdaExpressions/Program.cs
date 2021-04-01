using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4LambdaExpressions
{
    // lambda function: es una nomenclatura para crear metodos anonimos: func, action, predicate
    // puede tener un parameter x=>..., mas de uno: (x,y)=> o ninguno: ()
    // el operador => ejecuta la expresion
    class Program
    {
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        static void Main(string[] args)
        {
            Predicate<int> MayorDeEdad = edad => edad >= 18;
            //delegate (int edad) { return edad >= 18 };

            List<Persona> personas = new List<Persona>()
            {
                new Persona() {Edad = 14, Nombre = "oscar1"},
                new Persona() {Edad = 18, Nombre = "oscar2"},
                new Persona() {Edad = 18, Nombre = "oscar3"},
                new Persona() {Edad = 12, Nombre = "oscar4"},
            };

            List<Persona> mayoresDeEdad = personas.Where(a => MayorDeEdad(a.Edad)).ToList();

            List<Persona> mayoresDeEdad2 = personas.Where(a => a.Edad >= 18).ToList();

            Console.WriteLine(mayoresDeEdad.Count());
            Console.WriteLine(mayoresDeEdad2.Count());
        }
    }
}
