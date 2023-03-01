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
        public string ILevel { get; set; }
    }
    public class Head : OurItem
    {
        public Head()
        {
            Icon = "empty_head.png";
            ItemName = "Head";
        }
    }
    public class Neck : OurItem
    {
        public Neck()
        {
            Icon = "empty_neck.png";
            ItemName = "Neck";
        }
    }
    public class Shoulder : OurItem
    {
        public Shoulder()
        {
            Icon = "empty_shoulder.png";
            ItemName = "Shoulder";
        }
    }
    public class Chest : OurItem
    {
        public Chest()
        {
            Icon = "empty_chest.png";
            ItemName = "Chest";
        }
    }
    public class Waist : OurItem
    {
        public Waist()
        {
            Icon = "empty_waist.png";
            ItemName = "Waist";
        }
    }
    public class Legs : OurItem
    {
        public Legs()
        {
            Icon = "empty_legs.png";
            ItemName = "Legs";
        }
    }
    public class Feet : OurItem
    {
        public Feet()
        {
            Icon = "empty_feet.png";
            ItemName = "Feet";
        }
    }
    public class Wrist : OurItem
    {
        public Wrist()
        {
            Icon = "empty_wrist.png";
            ItemName = "Wrist";
        }
    }
    public class Hands : OurItem
    {
        public Hands()
        {
            Icon = "empty_hands.png";
            ItemName = "Hands";
        }
    }
    public class Ring1 : OurItem
    {
        public Ring1()
        {
            Icon = "empty_ring.png";
            ItemName = "Ring";
        }
    }
    public class Ring2 : OurItem
    {
        public Ring2()
        {
            Icon = "empty_ring.png";
            ItemName = "Ring";
        }
    }
    public class Trinket1 : OurItem
    {
        public Trinket1()
        {
            Icon = "empty_trinket.png";
            ItemName = "Trinket";
        }
    }
    public class Trinket2 : OurItem
    {
        public Trinket2()
        {
            Icon = "empty_trinket.png";
            ItemName = "Trinket";
        }
    }
    public class Back : OurItem
    {
        public Back()
        {
            Icon = "empty_chest.png";
            ItemName = "Back";
        }
    }
    public class Mainhand : OurItem
    {
        public Mainhand()
        {
            Icon = "empty_mainhand.png";
            ItemName = "Mainhand";
        }
    }
    public class Offhand : OurItem
    {
        public Offhand()
        {
            Icon = "empty_offhand.png";
            ItemName = "Offhand";
        }
    }
    public class Tabard : OurItem
    {
        public Tabard()
        {
            Icon = "empty_tabard.png";
            ItemName = "Tabard";
        }
    }
    public class Shirt : OurItem
    {
        public Shirt()
        {
            Icon = "empty_shirt.png";
            ItemName = "Shirt";
        }
    }
}
