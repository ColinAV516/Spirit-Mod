using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Putrid
{
    public class PutridPiece : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Putrid Piece";
            item.width = 38;
            item.height = 42;
            item.maxStack = 999;
            item.value = 100;
            item.rare = 4;
        }
    }
} 