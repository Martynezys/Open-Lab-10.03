using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        private string title;
        public string Title 
        {
          get { return title; }
          set { title = value; }
        }
        private int pages;
        public int Pages
        {
            get { return pages; }
            set
            {

                if (pages < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set  
            {
                if (releaseDate < 1450 && releaseDate > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }
            }
        }

        public Book () 
        {
            this.title = "-1";
            this.pages = -1;
            this.category= "-1";
            this.author = "-1";
            this.releaseDate = -1;
        }

        public Book (string xTitle, int xPages)
        {
            this.title = xTitle;
            this.pages = xPages;
            
            this.category= "-1";
            this.author = "-1";
            this.releaseDate = -1;
        }

        public Book (string xTitle, int XPages, string xCategory, string xAuthor, int xReleaseDate)
        {
            this.title = xTitle;
            this.pages = XPages;
            this.category = xCategory;
            this.author = xAuthor;
            this.releaseDate = xReleaseDate;
        }




        public void OlkoBolko()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Pages);
            Console.WriteLine(Category);
            Console.WriteLine(Author);
            Console.WriteLine(ReleaseDate);

        }


    }
}