using System;
using System.Globalization;
using System.Collections.Generic;

namespace LaboratorioNo._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            string nuevo;            
            IList<Book> listaLibro = new List<Book>();
            IList<Magazine> listaRevista = new List<Magazine>();
            int idRevista=1;
            int idLibro=1;                
            
           do{
            Console.WriteLine("Ingrese su opción");
            Console.WriteLine("Libro:1 o Revista:2");
            tipo = Console.ReadLine();  
            if(tipo=="1")
            {
                Book libro = new Book();
                libro.Id=idLibro;
                idLibro++;       
                listaLibro.Add(libro.RegistroLibro(libro));
                libro.imprimirListadoLibro(listaLibro);
            }   
            else
            {
                Magazine revista = new Magazine();
                revista.Id=idRevista;
                idRevista++;
                listaRevista.Add(revista.RegistroRevista(revista));                
                revista.imprimirListadoRevista(listaRevista); 
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Desea ingresar de nuevo");
            Console.WriteLine("si:s o no:n");
            nuevo = Console.ReadLine();
            }while(nuevo=="s");                 
        }



    }
}
