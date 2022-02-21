using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Trade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Deal { get; set; } //Deal bigint or long
        public long Login { get; set; } //Login bigint or long
        public int Entry { get; set; } //Entry int
        public int Action { get; set; } //Action int
        public DateTime Time { get; set; } //Time datetime
        public string Symbol { get; set; } //Symbol string
        public Decimal Price { get; set; } //Price double
        public Decimal Profit { get; set; } //Profit double
        public long Volume { get; set; } //Volume bigint or long
    }
}
