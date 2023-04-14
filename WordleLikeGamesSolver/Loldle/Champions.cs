using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleLikeGamesSolver.Loldle
{
    public class Champion
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public Genders Gender { get; set; }
        public PositionTypes[] Positions { get; set; }
        public SpeciesTypes[] Species { get; set; }
        public ResourceTypes Resource { get; set; }
        public RangeTypes[] Ranges { get; set; }
        public RegionTypes[] Regions { get; set; }
        public int ReleaseYear { get; set; }
        public enum Genders
        {
            Male,
            Female,
            Other
        }
        public enum PositionTypes
        {
            Top,
            Jungle,
            Middle,
            Support,
            Bottom
        }
        public enum SpeciesTypes
        {
            Unknown,
            Cat,
            MagicallyAltered,
            ChemicallyAltered,
            Cyborg,
            VoidBeing,
            Magicborn,
            Aspect,
            Vastayan,
            Golem,
            Human,
            Yeti,
            Demon,
            Spirit,
            GodWarrior,
            Yordle,
            Undead,
            Iceborn,
            Troll,
            Rat,
            Spiritualist,
            God,
            Revenant,
            Darkin,
            Minotaur,
            Celestial,
            Dragon,
            Brackern
        }
        public enum ResourceTypes
        {
            Mana,
            Manaless,
            Grit,
            HealthCosts,
            Rage,
            Fury,
            Ferocity,
            Heat,
            Flow,
            Energy,
            Courage,
            Bloodthirst,
            Shield
        }
        public enum RangeTypes
        {
            Melee,
            Ranged
        }
        public enum RegionTypes
        {
            Zaun,
            Void,
            Ixtal,
            Shurima,
            Ionia,
            Noxus,
            Runeterra,
            Demacia,
            Targon,
            Freljord,
            ShadowIsles,
            Piltover,
            BandleCity,
            Bilgewater,
            Camavor,
            Icathia
        }
    }
    public class ChampionsList
    {
        public int LoldleVersion { get; set; }
        public Champion[] Champions { get; set; }
        public static ChampionsList GenerateChampionList()
        {
            return CurrentChampionsList.List;
        }
        public void SaveToFile()
        {
            File.WriteAllText("Loldle\\Champions.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
        public static bool ChampionListExists()
        {
            return File.Exists("Loldle\\Champions.json");
        }
        public static ChampionsList LoadChampionList()
        {
            if (!Directory.Exists("Loldle")) Directory.CreateDirectory("Loldle");
            try
            {
                ChampionsList loadedChampions = JsonConvert.DeserializeObject<ChampionsList>(File.ReadAllText("Loldle\\Champions.json"));
                if (ChampionListExists() && loadedChampions is not null && loadedChampions.Champions.Length > 0) return loadedChampions;
                else { ChampionsList championsList = GenerateChampionList(); championsList.SaveToFile(); return championsList; }
            }
            catch (Exception) { ChampionsList championsList = GenerateChampionList(); championsList.SaveToFile(); return championsList; }
        }
    }
}
