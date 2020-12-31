using Slis.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            /*string text = "9,578,974.50";
            int value = Convert.ToInt32(Convert.ToDecimal(text));*/

            //var populations = Dao.Population.GetAll();
            List<Population> populations = Dao.Population.GetAll();

            foreach (var population in populations)
            {
                Console.WriteLine(population);

                //$"{population.LibraryId} / {population.IsMale} / {population.AgeCode} / {population.Value}
            }
        }
    }
}
