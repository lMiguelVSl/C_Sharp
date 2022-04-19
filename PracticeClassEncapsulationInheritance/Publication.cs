using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClassEncapsulationInheritance
{
    public enum PublicationType { Misc,Book,Magazine,Article};
    public abstract class Publication
    {
        private bool published = false;
        private DateTime datePublished;
        private int totalPages;

        public string Publisher {get;}
        public string  Title {get;}
        public Publication Type { get;}
        public string CopyRightName { get;private set; }
        public int CopyRightDate { get; private set; }
        public int Pages
        {
            get { return totalPages; }
            set
            {
                if (totalPages<=0)
                {
                    throw new ArgumentOutOfRangeException("El numero de paginas no puede ser 0 o negativo");
                }
                else
                {
                    totalPages = value;
                }
            }
        }
        public Publication(string publisher,string title, PublicationType type)
        {
            if (String.IsNullOrWhiteSpace(publisher))
            {
                throw new ArgumentException("El editor es requerido");
            }
            Publisher = publisher;
            if (String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("El titulo es requerido");
            }
            this.Title = title;

            this.Type = type;
        }
        public string GetPublicationDate()
        {
            if (!published)
            {
                return "NPA";
            }
            else
            {
                return datePublished.ToString("d");
            }
        }
        public void Publish(DateTime datePublished)
        {
            published = true;
            this.datePublished = datePublished;
        }
        public void CopyRight(string copyRightName, int copyRightDate)
        {
            if (String.IsNullOrWhiteSpace(copyRightName))
            {
                throw new ArgumentException("el nombre del copyright es necesario");  
            }
            else
            {
                this.CopyRightName = copyRightName;
            }

            int currentYear = DateTime.Now.Year;
            if (copyRightDate < currentYear - 10 || copyRightDate > currentYear + 2)
            {
                throw new ArgumentOutOfRangeException($"El year deberia de estar entre {currentYear - 10} y {currentYear + 1}");
            }
            else
            {
                CopyRightDate = copyRightDate;
            }

        }
        public override string ToString()
        {
            return Title;
        }
    }
}
