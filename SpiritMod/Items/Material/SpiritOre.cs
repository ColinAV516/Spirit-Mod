using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Material
{
    public class SpiritOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Spirit Ore";
            item.width = 14;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("SpiritOreTile");
        }
    }
}
