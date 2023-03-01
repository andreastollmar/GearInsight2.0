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
        public static async Task<Character> FetchCharacterAsync(string character, string realm) 
        {
            
            string clientId = "c2409be1a9e2473890d079632a06a265";
            string clientSecret = "XDO1WbK2BJ36OfLyo90nYVnUyGj5yHNd";



            var warcraftClient = new WarcraftClient(clientId, clientSecret, ArgentPonyWarcraftClient.Region.Europe, ArgentPonyWarcraftClient.Locale.en_GB);
            RequestResult<CharacterEquipmentSummary> armor = await warcraftClient.GetCharacterEquipmentSummaryAsync(realm, character, "profile-eu");
            Character c = new Character(character, realm);
            RequestResult<CharacterStatisticsSummary> stats = await warcraftClient.GetCharacterStatisticsSummaryAsync(realm, character, "profile-eu");
            RequestResult<CharacterProfileSummary> profile = await warcraftClient.GetCharacterProfileSummaryAsync(realm, character, "profile-eu");
            RequestResult<CharacterMediaSummary> charMedia = await warcraftClient.GetCharacterMediaSummaryAsync(realm, character, "profile-eu");
            RequestResult<CharacterMythicKeystoneSeasonDetails> mythic = await warcraftClient.GetCharacterMythicKeystoneSeasonDetailsAsync(realm, character, 1, "profile-eu");

            c.AchievementPoints = profile.Value.AchievementPoints;
            c.AvgIlvl = profile.Value.AverageItemLevel;
            c.PlayedRace = profile.Value.Race.Name;
            c.Level = profile.Value.Level;
            c.CurrentGuild = profile.Value.Guild.Name;
            c.ActiveSpec = profile.Value.ActiveSpec.Name;
            c.PlayedClass = profile.Value.CharacterClass.Name;
            c.CharacterImage = charMedia.Value.Assets[3].Value.AbsoluteUri;
            c.Power.Rating = stats.Value.Power;



            if (stats.Success)
            {
                if (c.PlayedClass == "Warrior" || c.PlayedClass == "Death Knight" || c.ActiveSpec == "Retribution" || c.ActiveSpec == "Protection")
                {
                    c.Strength.Rating = stats.Value.Strength.Effective;

                    c.BackgroundImage = "lastfinalwarriorbg.png";

                    c.MeleeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeCrit.ToString());
                    c.MeleeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeCrit.ToString());

                    c.MeleeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeHaste.ToString());
                    c.MeleeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeHaste.ToString());
                }
                else if (c.PlayedClass == "Rogue" || c.PlayedClass == "Demon Hunter" || (c.PlayedClass == "Hunter" && c.ActiveSpec == "Survival") || c.ActiveSpec == "Windwalker" || c.ActiveSpec == "Brewmaster" || c.ActiveSpec == "Enhancement" || c.ActiveSpec == "Feral" || c.ActiveSpec == "Guardian")
                {
                    c.Agility.Rating = stats.Value.Agility.Effective;

                    c.BackgroundImage = "dhbg.png";

                    c.MeleeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeCrit.ToString());
                    c.MeleeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeCrit.ToString());

                    c.MeleeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.MeleeHaste.ToString());
                    c.MeleeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.MeleeHaste.ToString());
                }
                else if (c.PlayedClass == "Hunter")
                {
                    c.Agility.Rating = stats.Value.Agility.Effective;

                    c.BackgroundImage = "roguebg.png";

                    c.RangeHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.RangedHaste.ToString());
                    c.RangeHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.RangedHaste.ToString());

                    c.RangeCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.RangedCrit.ToString());
                    c.RangeCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.RangedCrit.ToString());

                }
                else if (c.PlayedClass == "Mage" || c.PlayedClass == "Warlock" || c.PlayedClass == "Priest" || c.PlayedClass == "Evoker" || c.ActiveSpec == "Mistweaver" || c.PlayedClass == "Shaman" || c.ActiveSpec == "Balance" || c.ActiveSpec == "Restoration" || c.ActiveSpec == "Holy")
                {
                    c.Intellect.Rating = stats.Value.Intellect.Effective;

                    c.BackgroundImage = "roguebg.png";

                    c.SpellHaste.Rating = Helpers.ExtractRatingFromStats(stats.Value.SpellHaste.ToString());
                    c.SpellHaste.Percent = Helpers.ExtractPercentFromStats(stats.Value.SpellHaste.ToString());

                    c.SpellCrit.Rating = Helpers.ExtractRatingFromStats(stats.Value.SpellCrit.ToString());
                    c.SpellCrit.Percent = Helpers.ExtractPercentFromStats(stats.Value.SpellCrit.ToString());

                }

                c.Mastery.Rating = Helpers.ExtractRatingFromStats(stats.Value.Mastery.ToString());
                c.Mastery.Percent = Helpers.ExtractPercentFromStats(stats.Value.Mastery.ToString());
                c.Versatility = stats.Value.Versatility.ToString();
                c.Health = stats.Value.Health.ToString();



            }

            if (armor.Success)
            {
                CharacterEquipmentSummary a = armor.Value;


                for (int i = 0; i < a.EquippedItems.Length; i++)
                {
                    if (a.EquippedItems[i].Slot.Name == "Head")
                    {
                        c.Head.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Head.ItemName = a.EquippedItems[i].Name;
                        c.Head.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> headMedia = await warcraftClient.GetItemMediaAsync(c.Head.wowheadId, "static-eu");
                        ItemMedia headIcon = headMedia.Value;

                        foreach (var headUri in headIcon.Assets)
                        {

                            c.Head.Icon = headUri.Value.AbsoluteUri;
                        }

                    }
                    if (a.EquippedItems[i].Slot.Name == "Neck")
                    {
                        c.Neck.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Neck.ItemName = a.EquippedItems[i].Name;
                        c.Neck.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> neckMedia = await warcraftClient.GetItemMediaAsync(c.Neck.wowheadId, "static-eu");
                        ItemMedia neckIcon = neckMedia.Value;
                        foreach (var neckUri in neckIcon.Assets)
                        {

                            c.Neck.Icon = neckUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Shoulders")
                    {
                        c.Shoulder.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Shoulder.ItemName = a.EquippedItems[i].Name;
                        c.Shoulder.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> shouldersMedia = await warcraftClient.GetItemMediaAsync(c.Shoulder.wowheadId, "static-eu");
                        ItemMedia shouldersIcon = shouldersMedia.Value;
                        foreach (var shouldersUri in shouldersIcon.Assets)
                        {

                            c.Shoulder.Icon = shouldersUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Shirt")
                    {
                        c.Shirt.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Shirt.ItemName = a.EquippedItems[i].Name;
                        c.Shirt.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> shirtMedia = await warcraftClient.GetItemMediaAsync(c.Shirt.wowheadId, "static-eu");
                        ItemMedia shirtIcon = shirtMedia.Value;
                        foreach (var shirtUri in shirtIcon.Assets)
                        {

                            c.Shirt.Icon = shirtUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Chest")
                    {
                        c.Chest.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Chest.ItemName = a.EquippedItems[i].Name;
                        c.Chest.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> chestMedia = await warcraftClient.GetItemMediaAsync(c.Chest.wowheadId, "static-eu");
                        ItemMedia chestIcon = chestMedia.Value;
                        foreach (var chestUri in chestIcon.Assets)
                        {

                            c.Chest.Icon = chestUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Waist")
                    {
                        c.Waist.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Waist.ItemName = a.EquippedItems[i].Name;
                        c.Waist.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> waistMedia = await warcraftClient.GetItemMediaAsync(c.Waist.wowheadId, "static-eu");
                        ItemMedia waistIcon = waistMedia.Value;
                        foreach (var waistUri in waistIcon.Assets)
                        {

                            c.Waist.Icon = waistUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Legs")
                    {
                        c.Legs.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Legs.ItemName = a.EquippedItems[i].Name;
                        c.Legs.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> legsMedia = await warcraftClient.GetItemMediaAsync(c.Legs.wowheadId, "static-eu");
                        ItemMedia legsIcon = legsMedia.Value;
                        foreach (var legsUri in legsIcon.Assets)
                        {

                            c.Legs.Icon = legsUri.Value.AbsoluteUri;
                        }
                    }

                    if (a.EquippedItems[i].Slot.Name == "Feet")
                    {
                        c.Feet.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Feet.ItemName = a.EquippedItems[i].Name;
                        c.Feet.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> feetMedia = await warcraftClient.GetItemMediaAsync(c.Feet.wowheadId, "static-eu");
                        ItemMedia feetIcon = feetMedia.Value;
                        foreach (var feetUri in feetIcon.Assets)
                        {

                            c.Feet.Icon = feetUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Wrist")
                    {
                        c.Wrist.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Wrist.ItemName = a.EquippedItems[i].Name;
                        c.Wrist.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> wristMedia = await warcraftClient.GetItemMediaAsync(c.Wrist.wowheadId, "static-eu");
                        ItemMedia wristIcon = wristMedia.Value;
                        foreach (var wristUri in wristIcon.Assets)
                        {

                            c.Wrist.Icon = wristUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Hands")
                    {
                        c.Hands.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Hands.ItemName = a.EquippedItems[i].Name;
                        c.Hands.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> handsMedia = await warcraftClient.GetItemMediaAsync(c.Hands.wowheadId, "static-eu");
                        ItemMedia handsIcon = handsMedia.Value;
                        foreach (var handsUri in handsIcon.Assets)
                        {

                            c.Hands.Icon = handsUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Ring 1")
                    {
                        c.Ring1.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Ring1.ItemName = a.EquippedItems[i].Name;
                        c.Ring1.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> ring1Media = await warcraftClient.GetItemMediaAsync(c.Ring1.wowheadId, "static-eu");
                        ItemMedia ring1Icon = ring1Media.Value;
                        foreach (var ring1Uri in ring1Icon.Assets)
                        {

                            c.Ring1.Icon = ring1Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Ring 2")
                    {
                        c.Ring2.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Ring2.ItemName = a.EquippedItems[i].Name;
                        c.Ring2.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> ring2Media = await warcraftClient.GetItemMediaAsync(c.Ring2.wowheadId, "static-eu");
                        ItemMedia ring2Icon = ring2Media.Value;
                        foreach (var ring2Uri in ring2Icon.Assets)
                        {

                            c.Ring2.Icon = ring2Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Trinket 1")
                    {
                        c.Trinket1.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Trinket1.ItemName = a.EquippedItems[i].Name;
                        c.Trinket1.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> trinket1Media = await warcraftClient.GetItemMediaAsync(c.Trinket1.wowheadId, "static-eu");
                        ItemMedia trinket1Icon = trinket1Media.Value;
                        foreach (var trinket1Uri in trinket1Icon.Assets)
                        {

                            c.Trinket1.Icon = trinket1Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Trinket 2")
                    {
                        c.Trinket2.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Trinket2.ItemName = a.EquippedItems[i].Name;
                        c.Trinket2.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> trinket2Media = await warcraftClient.GetItemMediaAsync(c.Trinket2.wowheadId, "static-eu");
                        ItemMedia trinket2Icon = trinket2Media.Value;
                        foreach (var trinket2Uri in trinket2Icon.Assets)
                        {

                            c.Trinket2.Icon = trinket2Uri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Back")
                    {
                        c.Back.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Back.ItemName = a.EquippedItems[i].Name;
                        c.Back.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> backMedia = await warcraftClient.GetItemMediaAsync(c.Back.wowheadId, "static-eu");
                        ItemMedia backIcon = backMedia.Value;
                        foreach (var backUri in backIcon.Assets)
                        {

                            c.Back.Icon = backUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Main Hand")
                    {
                        c.Mainhand.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Mainhand.ItemName = a.EquippedItems[i].Name;
                        c.Mainhand.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> mainhandMedia = await warcraftClient.GetItemMediaAsync(c.Mainhand.wowheadId, "static-eu");
                        ItemMedia mainhandIcon = mainhandMedia.Value;
                        foreach (var mainhandUri in mainhandIcon.Assets)
                        {

                            c.Mainhand.Icon = mainhandUri.Value.AbsoluteUri;
                        }
                    }
                    if (a.EquippedItems[i].Slot.Name == "Off Hand")
                    {
                        c.Offhand.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Offhand.ItemName = a.EquippedItems[i].Name;
                        c.Offhand.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> offhandMedia = await warcraftClient.GetItemMediaAsync(c.Offhand.wowheadId, "static-eu");
                        ItemMedia offhandIcon = offhandMedia.Value;
                        foreach (var offhandUri in offhandIcon.Assets)
                        {
                            c.Offhand.Icon = offhandUri.Value.AbsoluteUri;
                        }

                    }
                    if (a.EquippedItems[i].Slot.Name == "Tabard")
                    {
                        c.Tabard.wowheadId = a.EquippedItems[i].Media.Id;
                        c.Tabard.ItemName = a.EquippedItems[i].Name;
                        c.Tabard.ILevel = Helpers.ExtractValue(a.EquippedItems[i].Level.ToString());

                        RequestResult<ItemMedia> tabardMedia = await warcraftClient.GetItemMediaAsync(c.Tabard.wowheadId, "static-eu");
                        ItemMedia tabardIcon = tabardMedia.Value;
                        foreach (var tabardUri in tabardIcon.Assets)
                        {
                            c.Tabard.Icon = tabardUri.Value.AbsoluteUri;
                        }
                    }
                }
            }
            return c;
        }

    }
}
