using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClassEncapsulationInheritance
{
    public enum PublicationType { Misc,Book,Magazine,Article}; //enumero los tipos de publicacio n que pueden haber
    public abstract class Publication //publicacion es abstracta
    {
        private bool published = false; //saber si se publico
        private DateTime datePublished; //fecha de publicacion
        private int totalPages; //paginas de la publicacion

        public string Publisher {get;} //se declara la propiedad para publicar solo para obtener mas no modificarla
        public string  Title {get;} //se obtiene el titulo
        public PublicationType Type { get;} //tipo de publicacion
        public string CopyRightName { get;private set; }
        public int CopyRightDate { get; private set; }
        public int Pages //metodo de paginas para poder acceder a la propiedad totalpages ya que es privada (encapsulacion)
        {
            get { return totalPages; }
            set
            {
                if (totalPages<=0) //al cambiar la cantidad de paginas no pueden ser menores que 0
                {
                    throw new ArgumentOutOfRangeException("El numero de paginas no puede ser 0 o negativo");
                }
                else
                {
                    totalPages = value; //si es mayor que 0, se cambia el valor
                }
            }
        }
        public Publication(string title,string publisher, PublicationType type) //constructor de la publicacion
        {
            if (String.IsNullOrWhiteSpace(publisher)) //si se tiene un valor nulo o espacio en blanco en publicador
            {
                throw new ArgumentException("El editor es requerido"); //se saca el aviso de que es necesario un publicador
            }
            Publisher = publisher; //en la propiedad Publisher guardamos el publisher que se recibe como argumento
            if (String.IsNullOrWhiteSpace(title))  //si el titulo es null o espacio en blanco
            {
                throw new ArgumentException("El titulo es requerido"); //aviso
            }
            Title = title; //se guarda en el atributo Title

            Type = type;
        }
        public string GetPublicationDate()
        {
            if (!published) //si no se ha publicado
            {
                return "NPA"; //se retorna mensaje de no se ha publicado
            }
            else
            {
                return datePublished.ToString("d"); //ya se publico
            }
        }
        public void Publish(DateTime datepublished) //parametro fecha de publicacion 
        {
            published = true;//se cambia el boolean para confirmar que ya se publico
            datePublished = datepublished; //se le asigna el parametro recibido (fecha) para la fecha de publicacion
        }
        public void CopyRight(string copyRightName, int copyRightDate)
        {
            if (String.IsNullOrWhiteSpace(copyRightName)) //si es null se hace un anuncio
            {
                throw new ArgumentException("el nombre del copyright es necesario");  
            }
            else
            {
                CopyRightName = copyRightName; //si no es nulo se asigna el valor 
            }

            int currentYear = DateTime.Now.Year; //se guarda en una variable el year actual
            if (copyRightDate < currentYear - 10 || copyRightDate > currentYear + 2)
            {
                //rango de validez del copyRight
                throw new ArgumentOutOfRangeException($"El year deberia de estar entre {currentYear - 10} y {currentYear + 1}");
            }
            else
            {
                CopyRightDate = copyRightDate; //si esta en el rango se asigna 
            }

        }
        public override string ToString()
        {
            return Title;
        }
    }
}
