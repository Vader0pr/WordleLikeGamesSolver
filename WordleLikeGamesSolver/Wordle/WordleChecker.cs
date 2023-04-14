using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WordleLikeGamesSolver.Wordle
{
    public static class WordleChecker
    {
        public static async Task<string> GetTodaysWord()
        {
            HttpClient client = new();
            client.DefaultRequestHeaders.Host = "www.nytimes.com";
            client.DefaultRequestHeaders.Add("cookie", "nyt-gdpr=1");
            DateTime now = DateTime.UtcNow;
            string wordJson = await client.GetStringAsync($"https://www.nytimes.com/svc/wordle/v2/{DateTime.Today.ToString("yyyy-MM-dd")}.json");
            TodaysWord word = JsonConvert.DeserializeObject<TodaysWord>(wordJson);
            return word.Solution;
        }
        public static async Task<bool> CheckTodaysWord(string enteredWord)
        {
            string word = await GetTodaysWord();
            return word.Equals(enteredWord);
        }
    }
    public class TodaysWord
    {
        public int Id { get; set; }
        public string Solution { get; set; }
        public DateTime Print_date { get; set; }
        public int Days_since_launch { get; set; }
        public string Editor { get; set; }
    }
    public class Word
    {
        public Character[] Characters { get; set; }
        public Word(Character[] characters)
        {
            Characters = characters;
        }
        public Word(string word)
        {
            List<Character> characters = new List<Character>();
            for (int i = 0; i < 5; i++)
            {
                characters.Add(new Character { Id = i, CurrentCharacter = word[i] });
            }
            Characters = characters.ToArray();
        }
        public static List<Word> StringArrayToWords(string[] words)
        {
            List<Word> result = new List<Word>();
            foreach (string word in words)
            {
                result.Add(new Word(word));
            }
            return result;
        }
        public static async Task<Word> CheckForValidity(Word word)
        {
            string todaysWord = await WordleChecker.GetTodaysWord();
            List<Character> characters = new List<Character>();
            foreach (Character character in word.Characters)
            {
                if (character.CurrentCharacter == todaysWord[character.Id])
                {
                    character.CharacterValidity = Character.Validity.LetterAndSpot;
                    characters.Add(character);
                }
                else if (todaysWord.Contains(character.CurrentCharacter))
                {
                    character.CharacterValidity = Character.Validity.Letter;
                    characters.Add(character);
                }
                else
                {
                    character.CharacterValidity = Character.Validity.None;
                    characters.Add(character);
                }
            }
            return new Word(characters.ToArray());
        }
    }
    public class Character
    {
        public int Id { get; set; }
        public char CurrentCharacter { get; set; }
        public Validity CharacterValidity { get; set; } = Validity.Unknown;
        public enum Validity
        {
            Unknown,
            None,
            Letter,
            LetterAndSpot
        }
    }
}
