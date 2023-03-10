using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadaTest
{
    public class LadaApp
    {
        public void Run()
        {
            Console.WriteLine("Napiš Id = Vypíše ti to Název skladby a authora");
            var c = int.Parse(Console.ReadLine());
            GetId(c);
            Console.WriteLine("Chceš true nebo false záznamy ?");

            var e = bool.Parse(Console.ReadLine());
            TrueOrFalse(e);
        }
        public void GetId(int d)
        {
            using var dbContext = new AppDbContext();
            var context = dbContext.Songs;
            foreach (var item in context)
            {
                if (item.Id == d)
                {
                    Console.WriteLine(item.Name + " " + item.Author);
                }
            }

        }
        public void TrueOrFalse(bool r)
        {
            using var dbContext = new AppDbContext();
            var context = dbContext.Songs;

            foreach (var item in context)
            {
                if (item.IsChecked == r)
                {
                    Console.WriteLine(item.Name + ":" + item.Author + ":" + " " + item.Lenght + ":" + item.IsChecked);
                }
            }
        }
    }
}
