using System;
using System.Collections.Generic;
using System.Text;
using DnDPlayerCompanion.Enums;

namespace DnDPlayerCompanion
{
    public abstract class BaseCharacter
    {
        #region Base Character Properties
        #region Names
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        #endregion

        #region Ability Scores and Modifiers
        private int _strength;
        private int _dexterity;
        private int _constitution;
        private int _intelligence;
        private int _wisdom;
        private int _charisma;
        
        public int Strength
        {
            get { return _strength; }
            set
            {
                _strength = value;
                StrMod = SetAbilityMod(_strength);
            }
        }
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                _dexterity = value;
                DexMod = SetAbilityMod(_dexterity);
            }
        }        
        public int Constitution 
        {
            get { return _constitution; }
            set
            {
                _constitution = value;
                ConMod = SetAbilityMod(_constitution);
            }
        }
        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                _intelligence = value;
                IntMod = SetAbilityMod(_intelligence);
            }
        }
        public int Wisdom 
        {
            get { return _wisdom; }
            set
            {
                _wisdom = value;
                WisMod = SetAbilityMod(_wisdom);
            }
        }
        public int Charisma 
        {
            get { return _charisma; }
            set
            {
                _charisma = value;
                ChaMod = SetAbilityMod(_charisma);
            }
        }

        public int StrMod { get; private set; }
        public int DexMod { get; private set; }
        public int ConMod { get; private set; }
        public int IntMod { get; private set; }
        public int WisMod { get; private set; }
        public int ChaMod { get; private set; }
        #endregion

        #region Race, Class, Level, and Abilities
        public BaseRace Race { get; set; }
        public BaseClass Class { get; set; }
        public int Level { get; set; }
        public List<string> SelectedRaceAbilities { get; set; }
        public List<string> SelectedClassAbilities { get; set; }
        public List<string> Feats { get; set; }
        #endregion

        #region Description
        public Alignment Alignment { get; set; }
        public string Background { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Eye { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        #endregion

        #region Stats
        public int Experience { get; set; }
        public Size Size { get; set; }
        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int TemporaryHP { get; set; }
        public string HitDie { get; set; }
        public List<Language> Languages { get; set; }
        #endregion

        #region Equipment
        public List<string> Attacks { get; set; }
        public List<string> Weapons { get; set; }
        public List<string> Armor { get; set; }
        public Dictionary<string, int> Money { get; set; }
        public List<string> Equipment { get; set; }
        #endregion

        public string Notes { get; set; }
        #endregion

        #region Base Character Calculation Methods
        private int SetAbilityMod(int value)
        {
            return (value / 10) - 5;
        }
        #endregion
    }
}