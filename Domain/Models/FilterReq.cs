using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FilterReq
    {
        public long Login { get; set; } // Login bigint or long
        public long Deal { get; set; } // Deal bigint or long
        public int PageIndex { get; set; } // current pagination page number
        public int PageSize { get; set; } // current pagination page number
    }
}
