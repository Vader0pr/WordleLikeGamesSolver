using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleLikeGamesSolver.Loldle
{
    public static class CurrentChampionsList
    {
        public static ChampionsList List { get; set; } = new ChampionsList
        {
            LoldleVersion = 79,
            Champions = new Champion[]
            {
                new Champion
                {
                    Name = "Qiyana",
                    Icon = "Qiyana",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ixtal
                    },
                    ReleaseYear = 2019
                },
                new Champion
                {
                    Name = "Quinn",
                    Icon = "Quinn",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "Nunu & Willump",
                    Icon = "Nunu",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Yeti
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Warwick",
                    Icon = "Warwick",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.ChemicallyAltered,
                        Champion.SpeciesTypes.Cyborg,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Wukong",
                    Icon = "MonkeyKing",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Vastayan
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Ekko",
                    Icon = "Ekko",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2015
                },
                new Champion
                {
                    Name = "Elise",
                    Icon = "Elise",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee,
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Evelynn",
                    Icon = "Evelynn",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Demon,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Ezreal",
                    Icon = "Ezreal",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Rakan",
                    Icon = "Rakan",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Vastayan
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2017
                },
                new Champion
                {
                    Name = "Rammus",
                    Icon = "Rammus",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.GodWarrior
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Rek'Sai",
                    Icon = "RekSai",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Rage,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima,
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2014
                },
                new Champion
                {
                    Name = "Rell",
                    Icon = "Rell",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2020
                },
                new Champion
                {
                    Name = "Renata Glasc",
                    Icon = "Renata",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.ChemicallyAltered,
                        Champion.SpeciesTypes.Human,
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2022
                },
                new Champion
                {
                    Name = "Renekton",
                    Icon = "Renekton",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.GodWarrior,
                    },
                    Resource = Champion.ResourceTypes.Fury,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Rengar",
                    Icon = "Rengar",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Vastayan,
                    },
                    Resource = Champion.ResourceTypes.Ferocity,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ixtal,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Riven",
                    Icon = "Riven",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                    },
                    Resource = Champion.ResourceTypes.Manaless,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia,
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Rumble",
                    Icon = "Rumble",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle,
                    },
                    Resource = Champion.ResourceTypes.Heat,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Ryze",
                    Icon = "Ryze",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Tahm Kench",
                    Icon = "TahmKench",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Demon,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater,
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2015
                },
                new Champion
                {
                    Name = "Taliyah",
                    Icon = "Taliyah",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2016
                },
                new Champion
                {
                    Name = "Talon",
                    Icon = "Talon",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Taric",
                    Icon = "Taric",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Aspect,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia,
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Teemo",
                    Icon = "Teemo",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Thresh",
                    Icon = "Thresh",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Undead
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "Tristana",
                    Icon = "Tristana",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Trundle",
                    Icon = "Trundle",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Iceborn,
                        Champion.SpeciesTypes.Troll
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Tryndamere",
                    Icon = "Tryndamere",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Fury,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Twisted Fate",
                    Icon = "TwistedFate",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Twitch",
                    Icon = "Twitch",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.ChemicallyAltered,
                        Champion.SpeciesTypes.Rat
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Master Yi",
                    Icon = "MasterYi",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Yasuo",
                    Icon = "Yasuo",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Flow,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "Yone",
                    Icon = "Yone",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Manaless,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2020
                },
                new Champion
                {
                    Name = "Yorick",
                    Icon = "Yorick",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Yuumi",
                    Icon = "Yuumi",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Cat,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity
                    },
                    ReleaseYear = 2019
                },
                new Champion
                {
                    Name = "Udyr",
                    Icon = "Udyr",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord,
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Urgot",
                    Icon = "Urgot",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.ChemicallyAltered,
                        Champion.SpeciesTypes.Cyborg,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Illaoi",
                    Icon = "Illaoi",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2015
                },
                new Champion
                {
                    Name = "Irelia",
                    Icon = "Irelia",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Ivern",
                    Icon = "Ivern",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord,
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2016
                },
                new Champion
                {
                    Name = "Jarvan IV",
                    Icon = "JarvanIV",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Olaf",
                    Icon = "Olaf",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Iceborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Orianna",
                    Icon = "Orianna",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Golem
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Ornn",
                    Icon = "Ornn",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.God,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2017
                },
                new Champion
                {
                    Name = "Pantheon",
                    Icon = "Pantheon",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Aspect,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Poppy",
                    Icon = "Poppy",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Pyke",
                    Icon = "Pyke",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Revenant
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2018
                },
                new Champion
                {
                    Name = "Aatrox",
                    Icon = "Aatrox",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Darkin
                    },
                    Resource = Champion.ResourceTypes.Manaless,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "Ahri",
                    Icon = "Ahri",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Vastayan
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Akali",
                    Icon = "Akali",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Energy,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Akshan",
                    Icon = "Akshan",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2021
                },
                new Champion
                {
                    Name = "Alistar",
                    Icon = "Alistar",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Minotaur
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Amumu",
                    Icon = "Amumu",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Undead,
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Anivia",
                    Icon = "Anivia",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.God,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Annie",
                    Icon = "Annie",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Aphelios",
                    Icon = "Aphelios",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2019
                },
                new Champion
                {
                    Name = "Ashe",
                    Icon = "Ashe",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Iceborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Aurelion Sol",
                    Icon = "AurelionSol",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Celestial,
                        Champion.SpeciesTypes.Dragon
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra,
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2016
                },
                new Champion
                {
                    Name = "Azir",
                    Icon = "Azir",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.GodWarrior
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2014
                },
                new Champion
                {
                    Name = "Lee Sin",
                    Icon = "LeeSin",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Energy,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Samira",
                    Icon = "Samira",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2020
                },
                new Champion
                {
                    Name = "Sejuani",
                    Icon = "Sejuani",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Iceborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Senna",
                    Icon = "Senna",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Undead
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2019
                },
                new Champion
                {
                    Name = "Seraphine",
                    Icon = "Seraphine",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover,
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2020
                },
                new Champion
                {
                    Name = "Sett",
                    Icon = "Sett",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Vastayan
                    },
                    Resource = Champion.ResourceTypes.Grit,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2020
                },
                new Champion
                {
                    Name = "Shaco",
                    Icon = "Shaco",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Shen",
                    Icon = "Shen",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Energy,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Shyvana",
                    Icon = "Shyvana",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Dragon,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Fury,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Singed",
                    Icon = "Singed",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.ChemicallyAltered,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover,
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Sion",
                    Icon = "Sion",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Revenant
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Sivir",
                    Icon = "Sivir",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Skarner",
                    Icon = "Skarner",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Brackern
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Sona",
                    Icon = "Sona",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia,
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Soraka",
                    Icon = "Soraka",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Celestial
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia,
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Swain",
                    Icon = "Swain",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Sylas",
                    Icon = "Sylas",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia,
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2019
                },
                new Champion
                {
                    Name = "Syndra",
                    Icon = "Syndra",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Darius",
                    Icon = "Darius",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Diana",
                    Icon = "Diana",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Aspect,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Dr. Mundo",
                    Icon = "DrMundo",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.ChemicallyAltered,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.HealthCosts,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Draven",
                    Icon = "Draven",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Fiddlesticks",
                    Icon = "Fiddlesticks",
                    Gender = Champion.Genders.Other,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Demon,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Fiora",
                    Icon = "Fiora",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Fizz",
                    Icon = "Fizz",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Miss Fortune",
                    Icon = "MissFortune",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Galio",
                    Icon = "Galio",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Golem
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Gangplank",
                    Icon = "Gangplank",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Garen",
                    Icon = "Garen",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Manaless,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Gnar",
                    Icon = "Gnar",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Rage,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee,
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2014
                },
                new Champion
                {
                    Name = "Gragas",
                    Icon = "Gragas",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Graves",
                    Icon = "Graves",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Gwen",
                    Icon = "Gwen",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Camavor,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2021
                },
                new Champion
                {
                    Name = "Hecarim",
                    Icon = "Hecarim",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Undead
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Camavor,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2021
                },
                new Champion
                {
                    Name = "Heimerdinger",
                    Icon = "Heimerdinger",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Janna",
                    Icon = "Janna",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.God,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima,
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Jax",
                    Icon = "Jax",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Unknown
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Icathia,
                        Champion.RegionTypes.Runeterra,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Jayce",
                    Icon = "Jayce",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee,
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Jhin",
                    Icon = "Jhin",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2016
                },
                new Champion
                {
                    Name = "Jinx",
                    Icon = "Jinx",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.ChemicallyAltered,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "K'Sante",
                    Icon = "KSante",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2022
                },
                new Champion
                {
                    Name = "Kai'Sa",
                    Icon = "Kaisa",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima,
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2018
                },
                new Champion
                {
                    Name = "Kalista",
                    Icon = "Kalista",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Undead
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Camavor,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2014
                },
                new Champion
                {
                    Name = "Karma",
                    Icon = "Karma",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Karthus",
                    Icon = "Karthus",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Undead
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Kassadin",
                    Icon = "Kassadin",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima,
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Katarina",
                    Icon = "Katarina",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Manaless,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Kayle",
                    Icon = "Kayle",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Aspect,
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee,
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia,
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Kayn",
                    Icon = "Kayn",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Darkin,
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia,
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.Runeterra,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2017
                },
                new Champion
                {
                    Name = "Kennen",
                    Icon = "Kennen",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Energy,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Kha'Zix",
                    Icon = "Khazix",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Kindred",
                    Icon = "Kindred",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.God,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2015
                },
                new Champion
                {
                    Name = "Kled",
                    Icon = "Kled",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Courage,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2016
                },
                new Champion
                {
                    Name = "Kog'Maw",
                    Icon = "KogMaw",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "LeBlanc",
                    Icon = "Leblanc",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Leona",
                    Icon = "Leona",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Aspect,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Lillia",
                    Icon = "Lillia",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2020
                },
                new Champion
                {
                    Name = "Lissandra",
                    Icon = "Lissandra",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Iceborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "Lucian",
                    Icon = "Lucian",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "Lulu",
                    Icon = "Lulu",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Lux",
                    Icon = "Lux",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Xin Zhao",
                    Icon = "XinZhao",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia,
                        Champion.RegionTypes.Ionia,
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Zac",
                    Icon = "Zac",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Golem
                    },
                    Resource = Champion.ResourceTypes.HealthCosts,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2013
                },
                new Champion
                {
                    Name = "Zed",
                    Icon = "Zed",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Energy,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Zeri",
                    Icon = "Zeri",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2022
                },
                new Champion
                {
                    Name = "Ziggs",
                    Icon = "Ziggs",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom,
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Zilean",
                    Icon = "Zilean",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Magicborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Icathia,
                        Champion.RegionTypes.Runeterra,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Zoe",
                    Icon = "Zoe",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Aspect,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2017
                },
                new Champion
                {
                    Name = "Zyra",
                    Icon = "Zyra",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Unknown
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ixtal
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Xayah",
                    Icon = "Xayah",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Vastayan
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia
                    },
                    ReleaseYear = 2017
                },
                new Champion
                {
                    Name = "Xerath",
                    Icon = "Xerath",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.GodWarrior
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Caitlyn",
                    Icon = "Caitlyn",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Camille",
                    Icon = "Camille",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Cyborg,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover
                    },
                    ReleaseYear = 2016
                },
                new Champion
                {
                    Name = "Cassiopeia",
                    Icon = "Cassiopeia",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima,
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Cho'Gath",
                    Icon = "Chogath",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Corki",
                    Icon = "Corki",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity,
                        Champion.RegionTypes.Piltover
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Varus",
                    Icon = "Varus",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom,
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Darkin,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ionia,
                        Champion.RegionTypes.Runeterra,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Vayne",
                    Icon = "Vayne",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Veigar",
                    Icon = "Veigar",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity,
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Vel'Koz",
                    Icon = "Velkoz",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2014
                },
                new Champion
                {
                    Name = "Vex",
                    Icon = "Vex",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Yordle
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.BandleCity,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2021
                },
                new Champion
                {
                    Name = "Vi",
                    Icon = "Vi",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover,
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Viego",
                    Icon = "Viego",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Undead
                    },
                    Resource = Champion.ResourceTypes.Manaless,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Camavor,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2021
                },
                new Champion
                {
                    Name = "Viktor",
                    Icon = "Viktor",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Cyborg,
                        Champion.SpeciesTypes.Human
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Piltover,
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Vladimir",
                    Icon = "Vladimir",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Bloodthirst,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Camavor,
                        Champion.RegionTypes.Noxus,
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Volibear",
                    Icon = "Volibear",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.God,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Bard",
                    Icon = "Bard",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Celestial
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2015
                },
                new Champion
                {
                    Name = "Bel'Veth",
                    Icon = "Belveth",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Manaless,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2022
                },
                new Champion
                {
                    Name = "Blitzcrank",
                    Icon = "Blitzcrank",
                    Gender = Champion.Genders.Other,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Golem
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Zaun
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Brand",
                    Icon = "Brand",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord,
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Braum",
                    Icon = "Braum",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Iceborn
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Freljord
                    },
                    ReleaseYear = 2014
                },
                new Champion
                {
                    Name = "Nami",
                    Icon = "Nami",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Vastayan
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Nasus",
                    Icon = "Nasus",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.GodWarrior
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Nautilus",
                    Icon = "Nautilus",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Revenant
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2012
                },
                new Champion
                {
                    Name = "Neeko",
                    Icon = "Neeko",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Vastayan
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ixtal
                    },
                    ReleaseYear = 2018
                },
                new Champion
                {
                    Name = "Nidalee",
                    Icon = "Nidalee",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.Spiritualist
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee,
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ixtal
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Nilah",
                    Icon = "Nilah",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Bottom
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Bilgewater
                    },
                    ReleaseYear = 2022
                },
                new Champion
                {
                    Name = "Nocturne",
                    Icon = "Nocturne",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Demon,
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Runeterra
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Malphite",
                    Icon = "Malphite",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Golem
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Ixtal,
                        Champion.RegionTypes.Shurima
                    },
                    ReleaseYear = 2009
                },
                new Champion
                {
                    Name = "Malzahar",
                    Icon = "Malzahar",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Middle
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.VoidBeing
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Shurima,
                        Champion.RegionTypes.Void
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Maokai",
                    Icon = "Maokai",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Jungle,
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Spirit
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.ShadowIsles
                    },
                    ReleaseYear = 2011
                },
                new Champion
                {
                    Name = "Mordekaiser",
                    Icon = "Mordekaiser",
                    Gender = Champion.Genders.Male,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Top
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Revenant
                    },
                    Resource = Champion.ResourceTypes.Shield,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Melee
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Noxus
                    },
                    ReleaseYear = 2010
                },
                new Champion
                {
                    Name = "Morgana",
                    Icon = "Morgana",
                    Gender = Champion.Genders.Female,
                    Positions = new Champion.PositionTypes[]
                    {
                        Champion.PositionTypes.Support
                    },
                    Species = new Champion.SpeciesTypes[]
                    {
                        Champion.SpeciesTypes.Aspect,
                        Champion.SpeciesTypes.Human,
                        Champion.SpeciesTypes.MagicallyAltered
                    },
                    Resource = Champion.ResourceTypes.Mana,
                    Ranges = new Champion.RangeTypes[]
                    {
                        Champion.RangeTypes.Ranged
                    },
                    Regions = new Champion.RegionTypes[]
                    {
                        Champion.RegionTypes.Demacia,
                        Champion.RegionTypes.Targon
                    },
                    ReleaseYear = 2009
                }
            }
        };
    }
}
