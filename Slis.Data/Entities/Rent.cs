﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.Data
{
    public partial class Rent
    {
        public override string ToString()
        {
            return $"{RentId} / {RentDate} / {LibraryId} / {Isbn} / {ReturnedDate}";
        }
    }
}
