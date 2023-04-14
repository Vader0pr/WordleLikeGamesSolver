using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using HtmlAgilityPack;

namespace WordleLikeGamesSolver.Wordle
{
    public class Wordlist
    {
        public static async Task<List<string>> GetWordlist()
        {
            HttpClient client = new HttpClient();
            string html = await client.GetStringAsync("https://www.wordunscrambler.net/word-list/wordle-word-list");
            HtmlAgilityPack.HtmlDocument document = new();
            document.LoadHtml(html);
            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//ul[@class='list-unstyled']/li[@class='invert light']/a");
            List<string> words = new();
            foreach (HtmlNode node in nodes)
            {
                words.Add(node.InnerText);
            }
            return words;
        }
    }
}
