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
        public static async Task<List<Rates>> GetRatesAsync()
        {
            var assets = new RatesResponse();
            HttpResponseMessage response = await HttpClient.GetAsync("https://api.coincap.io/v2/rates");
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<RatesResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
        public static async Task<Rates> GetRatesByIdAsync(string id)
        {
            var assets = new Rates();
            string path = "https://api.coincap.io/v2/rates/" + id;
            HttpResponseMessage response = await HttpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<Rates>(result);
                return assets;
            }
            throw new ArgumentException("Error");
        }
    }
}
