using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz5
{
    class Matriz
    {
        private int[,] mat;
        private int[,] submat;


        public void Cargar()
        {
            Console.Write("Cuantas fila tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rd = new Random();
                    int ins = rd.Next(0, 100);
                    mat[f, c] = ins;
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void subMatriz(int filas, int columnas)
        {
            submat = new int[filas, columnas];
             
            for (int f = 0; f < submat.GetLength(0); f++)
            {
                for (int c = 0; c < submat.GetLength(1); c++)
                {
                 
                    submat[f, c] = mat[f, c];
                }
            }
            mat = new int[filas, columnas];
            mat = submat;
        }

        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Cargar();
            ma.Imprimir();
            Console.WriteLine("**********************************************************");
            ma.subMatriz(3, 4);
            ma.Imprimir();

            Console.ReadKey();
        }
    }
}