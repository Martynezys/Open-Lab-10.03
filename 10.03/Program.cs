using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR=new Book();
            
            
            LOTR.Title= "Lord of The Rings";
            LOTR.Pages= 1028;
            LOTR.Category= "Fantazy";
            LOTR.Author= "Oliver Krska";
            LOTR.ReleaseDate= 1985;
            LOTR.OlkoBolko();
            Console.ReadLine();
        }
    }
}
