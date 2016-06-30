using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Bow
{
    public class FBow : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Floran Bow"; //This is th item's name
            item.damage = 12; //This is the amount of damage the item does
            item.noMelee = true; //This makes sure the bow doesn't do melee damage
            item.ranged = true; //This causes your bow to do ranged damage
            item.width = 30; //Hitbox width
            item.height = 53; //Hitbox height
            item.toolTip = "Primitive, yet useful."; //Tooltip 2
            item.useTime = 27; //How long it takes to use the weapon. If this is shorter than the useAnimation it will fire twice in one click.
            item.useAnimation = 26;  //The animations time length
            item.useStyle = 5; //The style in which the item gets used. 5 for bows.
            item.shoot = 3; //Makes the bow shoot arrows
            item.useAmmo = 1; //Makes the bow consume arrows
            item.knockBack = 2; //The amount of knockback the item has
            item.rare = 2; //The item's name color
            item.useSound = 5; //Sound that gets played on use
            item.autoReuse = true; //if the Bow autoreuses or not
            item.shootSpeed = 8f; //The arrows speed when shot
            item.crit = 4; //Crit chance
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FloranBar", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}