using Entidades;
using System;

namespace EjemploColo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array de enteros
            int[] valores = { 3, 5, 2, 1, 5, 3, 7, 9, 8 };
            foreach (int i in valores)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------- ");

            //matriz de 3*3
            int[,] matrizNumeros = new int[3, 3] { { 5, 2, 1 }, { 7, 4, 5 }, { 2, 9, 10 } };
            foreach (int i in matrizNumeros)
            {
                Console.Write("{0} -", i);
            }

            //Array de string
            Console.WriteLine();
            string[] cadena = new string[3] { "argentinA", "BRASIL", "paraguay" }; 

           
            foreach (string item in cadena)
            {
                Console.WriteLine($"Pais: { item}"
               );
            }

            Persona persona1 = new Persona();
            persona1.Nombre = "Pepe";
            persona1.Edad = 22;

            Persona persona2 = new Persona();
            persona2.Nombre = "Carlos";
            persona2.Edad = 32;

            Persona[] Personas = new Persona[2];
            Personas[0] = persona1;
            Personas[1] = persona2;

            for(int i=0; i < Personas.Length; i++)
            {
                Console.WriteLine($"{Personas[i].ToString() }");
            }

            
        }
    }
}
