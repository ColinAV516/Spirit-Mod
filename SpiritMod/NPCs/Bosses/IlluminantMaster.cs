using Terraria;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpiritMod.NPCs.Bosses
{
    public class IlluminantMaster : ModNPC
    {
		private float XSpeed;
		private float YSpeed;
        public override void SetDefaults()
        {
            npc.name = "Illuminant Master";
            npc.displayName = "Illuminant Master";
            npc.width = 130;
            npc.height = 154;
            npc.damage = 32;
			npc.noTileCollide = true;
            npc.defense = 34;
			npc.boss = true;
            npc.lifeMax = 22000;
            npc.soundHit = 1;
            npc.soundKilled = 1;
			npc.noGravity = true;
            npc.value = 60f;
            npc.knockBackResist = 0f;
            Main.npcFrameCount[npc.type] = 7;
     
        }
		public override void AI()
        {
		if (npc.life < 11000)
		{ 
			float Xdis = Main.player[Main.myPlayer].Center.X - npc.Center.X;  // change myplayer to nearest player in full version
			float Ydis = Main.player[Main.myPlayer].Center.Y - npc.Center.Y; // change myplayer to nearest player in full version
			float Angle = (float)Math.Atan(Xdis / Ydis);
			float TrijectoryX = (float)(Math.Sin(Angle));
			float TrijectoryY = (float)(Math.Cos(Angle));
			npc.ai[0]++;
			if(npc.ai[0] % 250 == 75 && Main.player[Main.myPlayer].Center.Y < npc.Center.Y && Main.player[Main.myPlayer].Center.X < npc.Center.X) // X
			{
				XSpeed = 0 - TrijectoryX;
				YSpeed = 0 - TrijectoryY;
				//Main.NewText("" + XSpeed + "Is what it will go", 0, 0, 0, true);
			}
			
			if(npc.ai[0] % 250 == 75 && Main.player[Main.myPlayer].Center.Y < npc.Center.Y && Main.player[Main.myPlayer].Center.X > npc.Center.X) // X
			{
				XSpeed = 0 - TrijectoryX;
				YSpeed = 0 - TrijectoryY;
				//Main.NewText("" + XSpeed + "Is what it will go", 0, 0, 0, true);
			}
			if(npc.ai[0] % 250 == 75 && Main.player[Main.myPlayer].Center.Y >= npc.Center.Y && Main.player[Main.myPlayer].Center.X > npc.Center.X) // X
			{
				XSpeed = TrijectoryX;
				YSpeed = TrijectoryY;
				//Main.NewText("" + XSpeed + "Is what it will go", 0, 0, 0, true);
			}
			if(npc.ai[0] % 250 == 75 && Main.player[Main.myPlayer].Center.Y >= npc.Center.Y && Main.player[Main.myPlayer].Center.X <= npc.Center.X) // X
			{
				XSpeed = TrijectoryX;
				YSpeed = TrijectoryY;
				//Main.NewText("" + XSpeed + "Is what it will go", 0, 0, 0, true);
			}
			if(npc.ai[0] % 250 >= 76) // X
			{
				npc.velocity.X = XSpeed * 9;
				npc.velocity.Y = YSpeed * 9;
				//Main.NewText("" + XSpeed + "Is what it is moving at", 0, 0, 0, true);
			}
			if(npc.ai[0] % 250 >= 76 && npc.ai[0] % 5 == 0) // X
			{
			//	Projectile.NewProjectile(npc.position.X, npc.position.Y, 0, 0, mod.ProjectileType("IlluminantMasterVision"), 0, 0, Main.myPlayer);
				//Main.NewText("" + XSpeed + "Is what it is moving at", 0, 0, 0, true);
			}
			if(npc.ai[0] % 250 == 0) // Y
			{
				npc.position.X = (Main.player[Main.myPlayer].position.X - 300) + Main.rand.Next(600);
				npc.position.Y = (Main.player[Main.myPlayer].position.Y - 300) + Main.rand.Next(600);
				//Main.NewText("Teleported", 0, 0, 0, true);
			}
			if(npc.ai[0] % 250 < 75) // Z
			{
				npc.velocity.X = TrijectoryX;
				npc.velocity.Y = TrijectoryX;
			}
			if (npc.ai[0]%8==0)
            {
                npc.frame.Y = (int)(npc.height * npc.frameCounter);
                npc.frameCounter = (npc.frameCounter+1) % 5;
            }
		}
		if (npc.life >= 11000)
		{
			//first phase stuff.
		}
		}
    }
}