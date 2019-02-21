using System;
using System.Globalization;
using System.Collections.Generic;

namespace LaboratorioNo._1
{
    public class Magazine : Publication
    {
        private int id;
        private static List<Magazine> magazineList;

        public Magazine()
        {

        }

        public Magazine(string title, DateTime editionDate,string editorial,string[] autores,int id) : base(title,editionDate,editorial,autores)
        {
            Id=id;
        }
       
        public int Id
        {
            get{return id;}
            set{id=value;}
        }
        public static List<Magazine> makeMagazineList()
        {
            if(magazineList==null)
            {
                magazineList= new List<Magazine>();
            }
            return magazineList;
        }

        public Magazine  RegistroRevista(Magazine revista)
        {   
            string nuevo;
            int contadorAutores=0;
            Console.WriteLine("Ingrese titulo de revista");
            revista.Title=Console.ReadLine();
            Console.WriteLine("Ingrese el año de publicación");
            int anio=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de publicación,ej:1,2,3");
            int mes=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de publicación,ej:1,2,3");
            int dia=Int32.Parse(Console.ReadLine());
            revista.EditionDate=new DateTime(anio, mes, dia);
            Console.WriteLine("Ingrese nombre de editorial");
            revista.Editorial=Console.ReadLine();
            
            do{
                Console.WriteLine("Ingrese nombre de autor");
                revista.Autores[contadorAutores++] = Console.ReadLine();
                Console.WriteLine("Desea ingresar un nuevo autor");
                Console.WriteLine("si:s o no:n");
                nuevo = Console.ReadLine();
            }while(nuevo=="s");
            //listaRevista.Add(revista);
            return revista;                      
        }

        public void imprimirListadoRevista(IList<Magazine>listaRevista)
        {
            foreach (Magazine elemento in listaRevista){
                System.Console.WriteLine("*******************************");
                System.Console.WriteLine("ID DE REVISTA:{0} ", elemento.Id);
                System.Console.WriteLine("NOMBRE DE REVISTA:{0} ", elemento.Title);
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