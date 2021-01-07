using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public class Dao
    {
        public static BookDao Book { get; } = new BookDao();

        public static LibraryDao Library { get; } = new LibraryDao();

        public static PopulationDao Population { get; } = new PopulationDao();

        public static OwnDao Own { get; } = new OwnDao();
    }
}
