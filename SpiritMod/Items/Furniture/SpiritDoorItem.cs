using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Furniture
{
	public class SpiritDoorItem : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Spirit Door";
			item.width = 32;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 500;
			item.createTile = mod.TileType("SpiritDoorClosed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpiritWoodItem", 8);
            recipe.AddIngredient(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}