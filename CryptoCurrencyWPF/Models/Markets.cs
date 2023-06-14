using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyWPF.Models
{
    public class Markets
    {
        public string exchangeId { get; set; } = null!;
        public string rank { get; set; }= null!;
        public string baseSymbol { get; set; } = null!;
        public string baseId { get; set; } = null!;
        public string quoteSymbol { get; set; } = null!;
        public string quoteId { get; set; } = null!;
        public string priceQuote { get; set; } = null!;
        public string priceUsd { get; set; } = null!;
        public string? volumeUsd24Hr { get; set; }
        public string? percentExchangeVolume { get; set; }
        public string? tradesCount24Hr { get; set; }
        public DateTime updated { get; set; }
    }
}
