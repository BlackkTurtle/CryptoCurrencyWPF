using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyWPF.Models.Responses;
using CryptoCurrencyWPF.Models;
using Newtonsoft.Json;

namespace CryptoCurrencyWPF.ViewModels.APIData
{
    public partial class CryptoCurrencyAPI
    {
        public static List<Candles> GetCandlesAsync(string exchange,string interval,string baseid,string quoteid)
        {
            var assets = new CandlesResponse();
            string path = $"https://api.coincap.io/v2/candles?exchange={exchange}&interval={interval}&baseId={baseid}&quoteId={quoteid}";
            HttpResponseMessage response = HttpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<CandlesResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
    }
}
