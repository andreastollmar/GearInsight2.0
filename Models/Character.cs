using ArgentPonyWarcraftClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearInsight.Models
{
    public partial class Character
    {
        public Guid Id { get; set; }
        public string CharacterName { get; set; }
        public string Realm { get; set; }
        public string PlayedRace { get; set; }
        public int Level { get; set; }
        public string PlayedClass { get; set; }
        public string ActiveSpec { get; set; }
        public string CurrentGuild { get; set; }
        public int AvgIlvl { get; set; }
        public int AchievementPoints { get; set; }
        public string MPlusRating { get; set; }
        public string BackgroundImage { get; set; }


        public Head Head { get; set; } = new Head();
        public Neck Neck { get; set; } = new Neck();
        public Shoulder Shoulder { get; set; } = new Shoulder();
        public Chest Chest { get; set; } = new Chest();
        public Waist Waist { get; set; } = new Waist();
        public Legs Legs { get; set; } = new Legs();
        public Feet Feet { get; set; } = new Feet();
        public Wrist Wrist { get; set; } = new Wrist();
        public Hands Hands { get; set; } = new Hands();
        public Ring1 Ring1 { get; set; } = new Ring1();
        public Ring2 Ring2 { get; set; } = new Ring2();
        public Trinket1 Trinket1 { get; set; } = new Trinket1();
        public Trinket2 Trinket2 { get; set; } = new Trinket2();
        public Back Back { get; set; } = new Back();
        public Mainhand Mainhand { get; set; } = new Mainhand();
        public Offhand Offhand { get; set; } = new Offhand();
        public Tabard Tabard { get; set; } = new Tabard();
        public Shirt Shirt { get; set; } = new Shirt();
        public Stats Intellect { get; set; } = new Stats();
        public Stats Agility { get; set; } = new Stats();
        public Stats Strength { get; set; } = new Stats();

        public Stats SpellHaste { get; set; } = new Stats();
        public Stats MeleeHaste { get; set; } = new Stats();
        public Stats RangeHaste { get; set; } = new Stats();
        public Stats SpellCrit { get; set; } = new Stats();
        public Stats MeleeCrit { get; set; } = new Stats();
        public Stats RangeCrit { get; set; } = new Stats();
        public Stats Mastery { get; set; } = new Stats();
        public Stats Power { get; set; } = new Stats();
        public string Health { get; set; }
        public string Versatility { get; set; }



        public Character(string characterName, string realm)
        {
            CharacterName = characterName;
            Realm = realm;
            Id = new Guid();
        }

       
    }
}
