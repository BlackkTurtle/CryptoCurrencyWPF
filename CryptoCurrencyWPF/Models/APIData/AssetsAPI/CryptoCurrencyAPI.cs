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
        public static async Task<List<Assets>> GetAssetsAsync()
        {
            var assets = new AssetsResponse();
            HttpResponseMessage response = await HttpClient.GetAsync("https://api.coincap.io/v2/assets");
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<AssetsResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
        public static async Task<Assets> GetAssetsByIdAsync(string id)
        {
            var assets = new Assets();
            string path = "https://api.coincap.io/v2/assets/" + id;
            HttpResponseMessage response = await HttpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<Assets>(result);
                return assets;
            }
            throw new ArgumentException("Error");
        }
        public static async Task<List<AssetsHistory>> GetAssetsHistoryAsync(string id,string interval)
        {
            var assets = new AssetsHistoryResponse();
            string path = $"https://api.coincap.io/v2/assets/{id}/history?interval={interval}";
            HttpResponseMessage response = await HttpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<AssetsHistoryResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
        public static async Task<List<AssetsMarkets>> GetAssetsHMarketsAsync(string id)
        {
            var assets = new AssetsMarketsResponse();
            string path = $"https://api.coincap.io/v2/assets/{id}/markets";
            HttpResponseMessage response = await HttpClient.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                assets = JsonConvert.DeserializeObject<AssetsMarketsResponse>(result);
                return assets.Data;
            }
            throw new ArgumentException("Error");
        }
    }
}
