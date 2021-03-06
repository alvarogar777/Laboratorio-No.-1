using System;
using System.Globalization;
using System.Collections.Generic;

namespace LaboratorioNo._1{
    public class Book : Publication,IVisualizable
    {
        private int id;
        private string isbn;
        private bool readed;
        private int timeReaded;
        private Book libro;
        private static List<Book> bookList;
     
        public Book()
        {

        }

        public Book(string title, DateTime editionDate,string editorial,string[] autores,int id,string isbn,bool readed,int timeReaded) : base(title,editionDate,editorial,autores)
        {
            Id=id;
            Isbn=isbn;
            Readed=readed;
            TimeReaded=timeReaded;
        }

        public int Id
        {
            get{return id;}
            set{id=value;}
        }
        public string Isbn
        {
            get{return isbn;}
            set{isbn=value;}
        }
        public bool Readed
        {
            get{return readed;}
            set{readed=value;}
        }
        public int TimeReaded
        {
            get{return timeReaded;}
            set{timeReaded=value;}
        }

        public DateTime StartToSee(DateTime datel)
        {
            return datel;
        }

        public void StopToSee(DateTime datel,DateTime datef)
        {

        }

        public static List<Book> makeBookList()
        {
            if(bookList==null)
            {
                bookList= new List<Book>();
            }
            return bookList;
        }
        
        public Book  RegistroLibro
        {   
            get{return libro;}
            set {
            libro = value;
            string nuevo;
            int contadorAutores=0;
            Console.WriteLine("Ingrese titulo del libro");
            libro.Title=Console.ReadLine();
            Console.WriteLine("Ingrese el año de publicación");
            int anio=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de publicación,ej:1,2,3");
            int mes=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de publicación,ej:1,2,3");
            int dia=Int32.Parse(Console.ReadLine());
            libro.EditionDate=new DateTime(anio, mes, dia);
            Console.WriteLine("Ingrese nombre de editorial");
            libro.Editorial=Console.ReadLine();
            
            do{
                Console.WriteLine("Ingrese nombre de autor");
                libro.Autores[contadorAutores++] = Console.ReadLine();
                Console.WriteLine("Desea ingresar un nuevo autor");
                Console.WriteLine("si:s o no:n");
                nuevo = Console.ReadLine();
            }while(nuevo=="s");
                        
            }                
        }

      
        public void imprimirListadoLibro(IList<Book>listaLibro)
        {
            foreach (Book elemento in listaLibro){
                System.Console.WriteLine("*******************************");
                System.Console.WriteLine("ID DE LIBRO:{0} ", elemento.Id);
                System.Console.WriteLine("NOMBRE DE LIBRO:{0} ", elemento.Title);
                System.Console.WriteLine("AÑO DE PUBLICACION:{0} ", elemento.EditionDate);
                System.Console.WriteLine("NOMBRE DE LA EDITORIAL:{0} ", elemento.Editorial);
                System.Console.WriteLine("AUTORES:");
                foreach (string i in elemento.Autores)
                {
                    System.Console.WriteLine("{0} ", i);
                }                
            } 
         
        }

        
        
    }
}