using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyWPF.Models
{
    public class Assets
    {
        public string id { get; set; } = null!;
        public string rank { get; set; } = null!;
        public string symbol { get; set; } = null!;
        public string name { get; set; } = null!;
        public string supply { get; set; } = null!;
        public string? maxSupply { get; set; }
        public string marketCapUsd { get; set; }= null!;
        public string volumeUsd24Hr { get; set; } = null!;
        public string priceUsd { get; set; } = null!;
        public string? changePercent24Hr { get; set; }
        public string vwap24Hr { get; set; } = null!;
    }
}
