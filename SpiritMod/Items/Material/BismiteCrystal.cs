using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Material
{
    public class BismiteCrystal : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bismite Crystal";
            item.width = 24;
            item.height = 28;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 4;
        }
    }
}