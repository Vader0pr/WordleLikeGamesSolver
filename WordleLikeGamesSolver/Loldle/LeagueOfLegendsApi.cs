using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleLikeGamesSolver.Loldle
{
    public static class LeagueOfLegendsApi
    {
        public static async Task<int> GetLoldleVersionAsync()
        {
            HttpClient client = new HttpClient();
            string versionJson = await client.GetStringAsync("https://loldle-version.pages.dev/version.json");
            return JsonConvert.DeserializeObject<LoldleVersion>(versionJson).Version;
        }
        public static async Task<Stream> GetChampionIconAsync(string championIconName)
        {
            HttpClient client = new HttpClient();
            return await client.GetStreamAsync($"https://ddragon.leagueoflegends.com/cdn/13.7.1/img/champion/{championIconName}.png");
        }
    }
    public class LoldleVersion
    {
        public int Version { get; set; }
    }
}
