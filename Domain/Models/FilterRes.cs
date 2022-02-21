using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FilterRes
    {
        public IQueryable<Trade> Trades { get; set; } // returned trades
        public long Login { get; set; } // Login bigint or long
        public long Deal { get; set; } // Deal bigint or long
        public int PageIndex { get; set; } // current pagination page number
        public int PageSize { get; set; }  // Total Number of pages in pagination
        public int TotalTrades { get; set; } // Total Number of Trades
        public int TotalPages { get; set; }  // Total Number of pages in pagination
    }
}
