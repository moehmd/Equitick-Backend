using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface ITradeService
    {
        bool AddNewTrade(Trade newTrade);
        FilterRes GetFilteredTrades(FilterReq filterParams);
    }
}
