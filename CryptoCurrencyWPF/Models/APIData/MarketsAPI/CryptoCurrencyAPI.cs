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
        public static List<Markets> GetMarketsAsync()
        {
            var assets = new MarketsResponse();
            HttpResponseMessage response = HttpClient.GetAsync("https://api.coincap.io/v2/markets").Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<MarketsResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
    }
}
