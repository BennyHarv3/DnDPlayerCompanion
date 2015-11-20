using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Reflection;
using System.Resources;
using DnDPlayerCompanion;

namespace DnDPlayerCompanion.Races
{
    public class NextRace : BaseRace
    {
        private ResourceManager _raceResourceManager;

        public NextRace SubRace { get; set; }

        public NextRace() { }

        // TODO: Figure out how to read resource files
        public NextRace(string race)
        {
            
        }
    }
}