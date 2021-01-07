using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public partial class Book
    {
        public override string ToString()
        {
            return $"{Isbn} / {SetIsbn} /{Title} / {Author} / {Publisher} / {PublicationDate} / {Kdc}";
        }
    }
}
