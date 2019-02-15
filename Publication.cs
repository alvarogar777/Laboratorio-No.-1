using System;
namespace LaboratorioNo._1{
    public abstract class Publication
    {
        private string title;
        private DateTime editionDate;
        private string editorial;
        private string[] autores = new string[4];

        public string Title
        {
            get{return title;}
            set{title=value;} 
        }
        public DateTime EditionDate
        {
            get{return editionDate;}
            set{editionDate=value;}
        }
        public string Editorial
        {
            get{return editorial;}
            set{editorial=value;}
        }
        public string[] Autores
        {
            get{return autores;}
            set{autores=value;}
        }

    }
}