namespace Destiny.Models {

    public class RaidLoot 
    {
        public uint _hash { get; set; }
        public string Name { get; set; }
        public int[] EncounterNumber { get; set; }
        public WeaponTypes ItemType { get; set; }
        public DamageTypes DamageType { get; set; }
        public AmmoTypes AmmoType { get; set; }
        public string Icon { get; set; }
        public string Image { get; set; }

    }
}