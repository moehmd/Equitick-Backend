using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TradeRepository : ITradeRepository
    {
        public TradeContext _tradeContext;
        public TradeRepository(TradeContext tradeContext)
        {
            _tradeContext = tradeContext;
        }
        public IQueryable<Trade> GetTrades()
        {
            IQueryable<Trade> trades = _tradeContext.mt5_deals.OrderBy(x => x.Deal);
            return trades;
        }

        public bool AddTrade(Trade trade)
        {
            // return true if createdTrade is more than 0.
            _tradeContext.mt5_deals.Add(trade);
            var createdTrade = _tradeContext.SaveChanges();
            return createdTrade > 0;
        }
    }
}
