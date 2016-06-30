using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.Items.Weapon.Gun
{
    public class DusksMusket : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dusk's Musket";  
            item.damage = 45;  
            item.ranged = true;   
            item.width = 65;     
            item.height = 21;    
            item.useTime = 28;  
            item.useAnimation = 28;
            item.useStyle = 5;    
            item.noMelee = true; 
            item.knockBack = 4;
            item.value = 100000;
            item.rare = 6;
            item.useSound = 11;
            item.autoReuse = true;
            item.shoot = 10; 
            item.shootSpeed = 16f;
            item.useAmmo = ProjectileID.Bullet;
        }
    }
}