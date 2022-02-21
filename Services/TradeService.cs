    using Domain;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Models;
using System;
using System.Linq;

namespace Services
{
    public class TradeService : ITradeService
    {
        private ITradeRepository _tradeRepository;
        public TradeService(ITradeRepository tradeRepository)
        {
            _tradeRepository = tradeRepository;
        }

        public bool AddNewTrade(Trade newTrade)
        {
            return _tradeRepository.AddTrade(newTrade);
        }

        public FilterRes GetFilteredTrades(FilterReq filterReq)
        {
            IQueryable<Trade> trades = _tradeRepository.GetTrades();
            if (filterReq.Deal != 0)
            {
                trades = trades.Where(d => d.Deal == filterReq.Deal);
            }
            if (filterReq.Login != 0)
            {
                trades = trades.Where(l => l.Login.Equals(filterReq.Login));
            }

            Pagination paginationFilter = new Pagination(filterReq.PageIndex, filterReq.PageSize);
            return BuildResponse(trades, paginationFilter);
        }
        private FilterRes BuildResponse(IQueryable<Trade> trades, Pagination paginationFilter)
        {
            var results = new FilterRes();
            results.PageIndex = paginationFilter.PageIndex;
            results.TotalTrades = trades.Count();
            results.PageSize = paginationFilter.PageSize;
            var totalPages = (double)results.TotalTrades / (double)paginationFilter.PageSize;
            int roundedTotalPages = Convert.ToInt16(Math.Ceiling(totalPages));
            results.TotalPages = roundedTotalPages;
            results.Trades = trades.Skip((paginationFilter.PageIndex - 1) * paginationFilter.PageSize).Take(paginationFilter.PageSize);

            return results;
        }
    }
}
