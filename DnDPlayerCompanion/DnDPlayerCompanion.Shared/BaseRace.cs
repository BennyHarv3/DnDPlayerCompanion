using System.Collections.Generic;
using DnDPlayerCompanion.Enums;

namespace DnDPlayerCompanion
{
    public abstract class BaseRace
    {
        public Dictionary<AbilityEnum, int> AbilityMods { get; set; }
        public Size Size { get; set; }
        public int Speed { get; set; }
        public List<Language> Languages { get; set; }
        public Dictionary<string, string> RaceTraits { get; set; }
    }
}