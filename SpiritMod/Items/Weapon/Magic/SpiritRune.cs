using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace SpiritMod.Items.Weapon.Magic
{
	public class SpiritRune : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Spirit Rune";
			item.damage = 33;
			item.magic = true;
			item.mana = 3;
			item.width = 40;
			item.height = 40;
			item.toolTip = "Sprays dangerous runes.";
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 5;
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 3;
			item.useSound = 20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Rune");
			item.shootSpeed = 8f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            float SdirX = (Main.MouseWorld.X - player.position.X) * 7.5f;
            float SdirY = (Main.MouseWorld.Y - player.position.Y) * 7.5f;
            float angle = (float)Math.Atan((float)Main.rand.Next(-12, 12));
			Terraria.Projectile.NewProjectile(position.X, position.Y, speedX + angle, speedY + Main.rand.Next(-1, 1), mod.ProjectileType("Rune"), damage, knockBack, player.whoAmI, 0f, 0f);
            return false;
        }
	}
}