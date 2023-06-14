using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyWPF.Models
{
    public class Candles
    {
        public string open { get; set; } = null!;
        public string high { get; set; } = null!;
        public string low { get; set; } = null!;
        public string close { get; set; } = null!;
        public string volume { get; set; } = null!;
        public DateTime period { get; set; }
    }
}
