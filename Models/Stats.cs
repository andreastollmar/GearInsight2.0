using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearInsight.Models
{
    public class Stats
    {

        public int Rating { get; set; }
        public double? Percent { get; set; }

        //Primary
        public class Intellect : Stats
        {
            public Intellect() 
            {
                //effective
            }
        }
        public class Agility : Stats
        {
            public Agility()
            {
                //effective

            }
        }
        public class Strength : Stats
        {
            public Strength()
            {
                //effective

            }
        }


        //Secondary
        public class Mastery : Stats
        {
            public Mastery()
            {
                
            }
        }
        public class Versatility : Stats
        {
            public Versatility()
            {
                //speciell rating
            }
        }
        public class SpellHaste : Stats
        {
            public SpellHaste()
            {
                
            }
        }
        public class MeleeHaste : Stats
        {
            public MeleeHaste()
            {
                
            }
        }
        public class RangeHaste : Stats
        {
            public RangeHaste()
            {
                
            }
        }
        public class RangeCrit : Stats
        {
            public RangeCrit()
            {
                
            }
        }
        public class MeleeCrit : Stats
        {
            public MeleeCrit()
            {
                
            }
        }
        public class SpellCrit : Stats
        {
            public SpellCrit()
            {
                
            }
        }
    }
}
