using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Boss
{
	//imported from my tAPI mod because I'm lazy
	public class SuspiciousLookingGatewayFromHell : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Suspicious Looking Gateway From Hell";
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.toolTip = "A very specific name, ain't it?";
			item.rare = 9;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.useSound = 44;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedPlantBoss && player.ZoneDungeon;
		}

		public override bool UseItem(Player player)
			{
		if (NPC.CountNPCS(mod.NPCType("Argargothicon")) == 0)
			{
   				NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Argargothicon"));
				Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
				return true;
			}
			else
			{
			return false;
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
	}
}