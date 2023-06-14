using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyWPF.Models
{
    public class Exchanges
    {
        public string id { get; set; } = null!;
        public string name { get; set; } = null!;
        public string rank { get; set; } = null!;
        public string percentTotalVolume { get; set; } = null!;
        public string volumeUsd { get; set; } = null!;
        public string tradingPairs { get; set; } = null!;
        public bool socket { get; set; }
        public string exchangeUrl { get; set; } = null!;
        public DateTime updated { get; set; }
    }
}
