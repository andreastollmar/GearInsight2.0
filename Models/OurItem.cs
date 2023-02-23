using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearInsight.Models
{
    public class OurItem
    {
        public string Icon { get; set; } = "placeholder.png";
        public string ItemName { get; set; }
        public int wowheadId { get; set; }
        public string Enchantment { get; set; }
    }
    public class Head : OurItem
    {
        public Head()
        {
            Icon = "emptyhead.png";
        }
    }
    public class Neck : OurItem
    {
        public Neck()
        {
            Icon = "emptyneck.png";
        }
    }
    public class Shoulder : OurItem
    {
        public Shoulder()
        {
            Icon = "emptyshoulder.png";
        }
    }
    public class Chest : OurItem
    {
        public Chest()
        {
            Icon = "emptychest.png";
        }
    }
    public class Waist : OurItem
    {
        public Waist()
        {
            Icon = "emptywaist.png";
        }
    }
    public class Legs : OurItem
    {
        public Legs()
        {
            Icon = "emptylegs.png";
        }
    }
    public class Feet : OurItem
    {
        public Feet()
        {
            Icon = "emptyfeet.png";
        }
    }
    public class Wrist : OurItem
    {
        public Wrist()
        {
            Icon = "emptywrist.png";
        }
    }
    public class Hands : OurItem
    {
        public Hands()
        {
            Icon = "emptyhands.png";
        }
    }
    public class Ring1 : OurItem
    {
        public Ring1()
        {
            Icon = "emptyring.png";
        }
    }
    public class Ring2 : OurItem
    {
        public Ring2()
        {
            Icon = "emptyring.png";
        }
    }
    public class Trinket1 : OurItem
    {
        public Trinket1()
        {
            Icon = "emptytrinket.png";
        }
    }
    public class Trinket2 : OurItem
    {
        public Trinket2()
        {
            Icon = "emptytrinket.png";
        }
    }
    public class Back : OurItem
    {
        public Back()
        {
            Icon = "emptyback.png";
        }
    }
    public class Mainhand : OurItem
    {
        public Mainhand()
        {
            Icon = "emptymainhand.png";
        }
    }
    public class Offhand : OurItem
    {
        public Offhand()
        {
            Icon = "emptyoffhand.png";
        }
    }
    public class Tabard : OurItem
    {
        public Tabard()
        {
            Icon = "emptytabard.png";
        }
    }
    public class Shirt : OurItem
    {
        public Shirt()
        {
            Icon = "emptyshirt.png";
        }
    }
}
