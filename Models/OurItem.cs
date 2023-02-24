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
            ItemName = "Head";
        }
    }
    public class Neck : OurItem
    {
        public Neck()
        {
            Icon = "emptyneck.png";
            ItemName = "Neck";
        }
    }
    public class Shoulder : OurItem
    {
        public Shoulder()
        {
            Icon = "emptyshoulder.png";
            ItemName = "Shoulder";
        }
    }
    public class Chest : OurItem
    {
        public Chest()
        {
            Icon = "emptychest.png";
            ItemName = "Chest";
        }
    }
    public class Waist : OurItem
    {
        public Waist()
        {
            Icon = "emptywaist.png";
            ItemName = "Waist";
        }
    }
    public class Legs : OurItem
    {
        public Legs()
        {
            Icon = "emptylegs.png";
            ItemName = "Legs";
        }
    }
    public class Feet : OurItem
    {
        public Feet()
        {
            Icon = "emptyfeet.png";
            ItemName = "Feet";
        }
    }
    public class Wrist : OurItem
    {
        public Wrist()
        {
            Icon = "emptywrist.png";
            ItemName = "Wrist";
        }
    }
    public class Hands : OurItem
    {
        public Hands()
        {
            Icon = "emptyhands.png";
            ItemName = "Hands";
        }
    }
    public class Ring1 : OurItem
    {
        public Ring1()
        {
            Icon = "emptyring.png";
            ItemName = "Ring";
        }
    }
    public class Ring2 : OurItem
    {
        public Ring2()
        {
            Icon = "emptyring.png";
            ItemName = "Ring";
        }
    }
    public class Trinket1 : OurItem
    {
        public Trinket1()
        {
            Icon = "emptytrinket.png";
            ItemName = "Trinket";
        }
    }
    public class Trinket2 : OurItem
    {
        public Trinket2()
        {
            Icon = "emptytrinket.png";
            ItemName = "Trinket";
        }
    }
    public class Back : OurItem
    {
        public Back()
        {
            Icon = "emptyback.png";
            ItemName = "Back";
        }
    }
    public class Mainhand : OurItem
    {
        public Mainhand()
        {
            Icon = "emptymainhand.png";
            ItemName = "Mainhand";
        }
    }
    public class Offhand : OurItem
    {
        public Offhand()
        {
            Icon = "emptyoffhand.png";
            ItemName = "Offhand";
        }
    }
    public class Tabard : OurItem
    {
        public Tabard()
        {
            Icon = "emptytabard.png";
            ItemName = "Tabard";
        }
    }
    public class Shirt : OurItem
    {
        public Shirt()
        {
            Icon = "emptyshirt.png";
            ItemName = "Shirt";
        }
    }
}
