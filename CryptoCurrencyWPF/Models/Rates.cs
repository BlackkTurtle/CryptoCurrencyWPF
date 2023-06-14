using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyWPF.Models
{
    public class Rates
    {
        public string id { get; set; } = null!;
        public string symbol { get; set; }= null!;
        public string? currencySymbol { get; set; }
        public string type { get; set; }= null!;
        public string rateUsd { get; set; }= null!;
    }
}
