using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    class Dao
    {
        public static BookDao Book = new BookDao();

        public static LibraryDao Customer = new LibraryDao();

        public static RentDao Rent = new RentDao();

        public static OwnDao Own = new OwnDao();
    }
}
