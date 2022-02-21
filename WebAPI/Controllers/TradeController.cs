using Domain;
using Domain.Interfaces.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeController : ControllerBase
    {
        private ITradeService _tradeService;
        public TradeController(ITradeService tradeService)
        {
            _tradeService = tradeService;
        }

        [HttpPost("Trades")]
        // All Trades & Filtered by deal and/or login
        public IActionResult GetTrades([FromBody] FilterReq filterRequest)
        {
            return Ok(_tradeService.GetFilteredTrades(filterRequest));
        }

        [HttpPost("AddTrade")]
        /// add new trade
        public IActionResult AddTrade([FromBody] Trade newTrade)
        {
            return Ok(_tradeService.AddNewTrade(newTrade));
        }
    }
}

