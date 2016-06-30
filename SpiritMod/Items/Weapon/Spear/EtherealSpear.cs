using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Spear
{
    public class EtherealSpear : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BoneJavelin);
            item.name = "Ethereal Spear";
            item.useStyle = 1;
            item.width = 38;
            item.height = 38;
            item.noUseGraphic = true;
            item.useSound = 1;
            item.thrown = true;
            item.channel = true;
            item.noMelee = true;
            item.consumable = true;
            item.maxStack = 999;
            item.shoot = mod.ProjectileType("EtherealSpearProjectile");
            item.toolTip = "Inflicts Essence Trap";
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 11f;
            item.damage = 42;
            item.knockBack = 5f;
			item.value = Item.buyPrice(0, 0, 0, 80);
			item.value = Item.sellPrice(0, 0, 0, 20);
            item.crit = 6;
            item.rare = 5;
            item.autoReuse = true;
        }
    }
}