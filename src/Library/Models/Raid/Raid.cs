namespace Destiny.Models {

    public class Raid 
    {
        public uint _hash { get; set; }
        public uint _lootSourceHash { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }
        public RaidEncounter [] Encounters { get; set; }
        public RaidLoot[] Loot { get; set; }
    }
}
