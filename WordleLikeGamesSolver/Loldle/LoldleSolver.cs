using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordleLikeGamesSolver.Loldle;

namespace WordleLikeGamesSolver
{
    public partial class LoldleSolver : Form
    {
        ChampionsList championsList = new ChampionsList();
        public LoldleSolver()
        {
            InitializeComponent();
            CheckChampionsListVersion();
            LoadChampionsList();
        }
        private void LoadChampionsList()
        {
            championsList = ChampionsList.LoadChampionList();
            UpdateListBox(championsList);
        }
        private void UpdateListBox(ChampionsList list)
        {
            listBox1.Items.Clear();
            foreach (Champion champion in list.Champions)
            {
                listBox1.Items.Add(champion.Name);
            }
        }
        private async void FilterChampions()
        {
            List<Champion> filteredChampionsList = championsList.Champions.ToList();
            if (checkBox1.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Gender == (Champion.Genders)comboBox1.SelectedIndex).ToList();
            if (checkBox2.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Positions.Contains((Champion.PositionTypes)comboBox2.SelectedIndex)).ToList();
            if (checkBox7.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Positions.Contains((Champion.PositionTypes)comboBox7.SelectedIndex)).ToList();
            if (checkBox8.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Positions.Contains((Champion.PositionTypes)comboBox8.SelectedIndex)).ToList();
            if (checkBox9.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Species.Contains((Champion.SpeciesTypes)comboBox9.SelectedIndex)).ToList();
            if (checkBox11.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Species.Contains((Champion.SpeciesTypes)comboBox10.SelectedIndex)).ToList();
            if (checkBox10.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Species.Contains((Champion.SpeciesTypes)comboBox11.SelectedIndex)).ToList();
            if (checkBox3.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Resource == (Champion.ResourceTypes)comboBox3.SelectedIndex).ToList();
            if (checkBox12.Checked)
            {
                if (checkBox4.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Ranges.Contains(Champion.RangeTypes.Melee)).ToList();
                if (checkBox5.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Ranges.Contains(Champion.RangeTypes.Ranged)).ToList();
            }
            if (checkBox6.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Regions.Contains((Champion.RegionTypes)comboBox4.SelectedIndex)).ToList();
            if (checkBox14.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Regions.Contains((Champion.RegionTypes)comboBox5.SelectedIndex)).ToList();
            if (checkBox13.Checked) filteredChampionsList = filteredChampionsList.Where(x => x.Regions.Contains((Champion.RegionTypes)comboBox6.SelectedIndex)).ToList();
            if (checkBox15.Checked)
            {
                if (comboBox12.SelectedIndex == 0) filteredChampionsList = filteredChampionsList.Where(x => x.ReleaseYear > numericUpDown1.Value).ToList();
                if (comboBox12.SelectedIndex == 1) filteredChampionsList = filteredChampionsList.Where(x => x.ReleaseYear == numericUpDown1.Value).ToList();
                if (comboBox12.SelectedIndex == 2) filteredChampionsList = filteredChampionsList.Where(x => x.ReleaseYear < numericUpDown1.Value).ToList();
            }
            UpdateListBox(new ChampionsList { LoldleVersion = 0, Champions = filteredChampionsList.ToArray() });
        }
        private void CheckChampionsListVersion()
        {
            if (ChampionsList.LoadChampionList().LoldleVersion < CurrentChampionsList.List.LoldleVersion) ChampionsList.GenerateChampionList().SaveToFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterChampions();
        }
    }
}
