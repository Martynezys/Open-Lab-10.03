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
            Book LOTR=new Book("Lord of The Rings", 1028, "Fantasy", "Oliver Krska", 1985);

            Book LOTR2= new Book("Lord of The Rings 2", 416, "Fantasy", "Oliver Krska", 1987);

            Book LOTR3= new Book("Lord of The Rings 3", 512, "Fantasy", "Oliver Krska", 1989);

            Book HOBIT= new Book("Hobit", 420, "Fantasy", "Oliver Krska", 1986);

            HOBIT.OlkoBolko();
            Console.ReadLine();

        }
    }
}
