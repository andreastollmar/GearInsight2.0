using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GearInsight.Database;
using GearInsight.Models;

namespace GearInsight.ViewModels
{
    internal class CharacterPageViewModel
    {

        public Character TheCharacter { get; set; }

        public CharacterPageViewModel(string character, string realm)
        {
            var task = Task.Run(() => Mongo.CreateCharacter(character, realm));
            task.Wait();
            TheCharacter = task.Result;
        }

    }
}
