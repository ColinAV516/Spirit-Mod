using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SpiritMod.Tiles.Furniture
{
	public class SpiritWorkbench : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = new int[]{ 18 };
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			AddMapEntry(new Color(30, 144, 255), "Spirit Workbench");
			disableSmartCursor = true;
			adjTiles = new int[]{ TileID.WorkBenches };
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
			Terraria.Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("SpiritWorkbench"));
        }
    }
}