using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CryptoCurrencyWPF.Models;
using CryptoCurrencyWPF.Models.Responses;
using Newtonsoft.Json;

namespace CryptoCurrencyWPF.ViewModels.APIData
{
    public partial class CryptoCurrencyAPI
    {
        static HttpClient HttpClient = new HttpClient();
        public static  List<Assets> GetTop10Assets(string name)
        {
                var assets = new AssetsResponse();
                var response = Task.Run(async () => await HttpClient.GetAsync("https://api.coincap.io/v2/assets")).Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    assets = JsonConvert.DeserializeObject<AssetsResponse>(result);
                    return assets.Data.Where(d=>d.name.ToLower().Contains(name.ToLower())).Take(10).ToList();
                }
                throw new ArgumentException("Error");
        }
        public static Assets GetAssetsByIdAsync(string id)
        {
            var assets = new Assets();
            string path = "https://api.coincap.io/v2/assets/" + id;
            var response = Task.Run(async () => await HttpClient.GetAsync(path)).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<Assets>(result);
                return assets;
            }
            throw new ArgumentException("Error");
        }
        public static List<AssetsHistory> GetAssetsHistoryAsync(string id,string interval)
        {
            var assets = new AssetsHistoryResponse();
            string path = $"https://api.coincap.io/v2/assets/{id}/history?interval={interval}";
            HttpResponseMessage response = HttpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<AssetsHistoryResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
        public static List<AssetsMarkets> GetAssetsHMarketsAsync(string id)
        {
            var assets = new AssetsMarketsResponse();
            string path = $"https://api.coincap.io/v2/assets/{id}/markets";
            HttpResponseMessage response = HttpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                assets = JsonConvert.DeserializeObject<AssetsMarketsResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
    }
}
