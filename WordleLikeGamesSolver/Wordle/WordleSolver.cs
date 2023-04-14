using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordleLikeGamesSolver.Wordle;

namespace WordleLikeGamesSolver
{
    public partial class WordleSolver : Form
    {
        List<string> words;
        public WordleSolver()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Task.Run(LoadWords);
        }
        private async Task LoadWords()
        {
            words = await Wordlist.GetWordlist();
            await RefreshWordsListBox();
        }
        private Task RefreshWordsListBox()
        {
            listBox1.Items.Clear();
            words.ForEach(word => listBox1.Items.Add(word));
            listBox1.Refresh();
            return Task.CompletedTask;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(SubmitWord);
        }
        private async Task SubmitWord()
        {
            if (textBox1.Text.Length == 5)
            {
                bool correct = await WordleChecker.CheckTodaysWord(textBox1.Text);
                if (correct)
                {
                    string todaysWord = await WordleChecker.GetTodaysWord();
                    MessageBox.Show("Correct word!", todaysWord);
                }
                else
                {
                    Word wordForValidating = new Word(textBox1.Text);
                    Word validatedWord = await Word.CheckForValidity(wordForValidating);
                    List<string> wordsUpdate = words;
                    foreach (Character character in validatedWord.Characters)
                    {
                        if (character.CharacterValidity == Character.Validity.LetterAndSpot)
                            wordsUpdate = wordsUpdate.Where(x => x[character.Id] == character.CurrentCharacter).ToList();
                        if (character.CharacterValidity == Character.Validity.Letter)
                            wordsUpdate = wordsUpdate.Where(x => x.Contains(character.CurrentCharacter)).ToList();
                        if (character.CharacterValidity == Character.Validity.None)
                            wordsUpdate = wordsUpdate.Where(x => !x.Contains(character.CurrentCharacter)).ToList();
                    }
                    words = wordsUpdate;
                    Task.Run(RefreshWordsListBox);
                }
            }
        }
    }
}
