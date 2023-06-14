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
        public static async Task<List<Exchanges>> GetExchangesAsync()
        {
            var assets = new ExchangesResponse();
            HttpResponseMessage response = await HttpClient.GetAsync("https://api.coincap.io/v2/exchanges");
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<ExchangesResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
        public static async Task<Exchanges> GetExchangeByIdAsync(string id)
        {
            var assets = new Exchanges();
            string path = "https://api.coincap.io/v2/exchanges/" + id;
            HttpResponseMessage response = await HttpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<Exchanges>(result);
                return assets;
            }
            throw new ArgumentException("Error");
        }
    }
}
