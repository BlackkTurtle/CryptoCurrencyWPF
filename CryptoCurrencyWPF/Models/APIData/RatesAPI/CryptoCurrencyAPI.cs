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
        public static List<Rates> GetTop10RatesAsync(string name)
        {
            var assets = new RatesResponse();
            HttpResponseMessage response = HttpClient.GetAsync("https://api.coincap.io/v2/rates").Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<RatesResponse>(result);
                return assets.Data.Where(a=>a.id.Contains(name)).Take(10).ToList();
            }
            throw new ArgumentException("Error");
        }
        public static Rates GetRatesByIdAsync(string id)
        {
            var assets = new Rates();
            string path = "https://api.coincap.io/v2/rates/" + id;
            HttpResponseMessage response = HttpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<Rates>(result);
                return assets;
            }
            throw new ArgumentException("Error");
        }
    }
}
