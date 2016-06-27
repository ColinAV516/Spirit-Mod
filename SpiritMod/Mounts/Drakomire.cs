using System;
using Terraria;
using Terraria.ModLoader;

namespace SpiritMod.Mounts
{
	public class Drakomire : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.buff = mod.BuffType("DrakomireMountBuff");
			mountData.heightBoost = 20;
			mountData.fallDamage = 0f;
			mountData.runSpeed = 3f;
			mountData.dashSpeed = 3f;
			mountData.flightTimeMax = 0;
			mountData.fatigueMax = 0;
			mountData.jumpHeight = 8;
			mountData.acceleration = 0.1f;
			mountData.jumpSpeed = 10f;
			mountData.blockExtraJumps = true;
			mountData.totalFrames = 8;
			mountData.constantJump = false;
			int[] array = new int[mountData.totalFrames];
			for (int i = 0; i < array.Length; i++)
			{
				if (i == 1)
				{
					array[i] = 24;
				}
				else if (i == 3 || i == 4 || i == 5)
				{
					array[i] = 18;
				}
				else
				{
					array[i] = 20;
				}
			}
			mountData.playerYOffsets = array;
			mountData.yOffset = 6;
			mountData.xOffset = -7;
			mountData.bodyFrame = 3;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 1;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 6;
			mountData.runningFrameDelay = 20;
			mountData.runningFrameStart = 2;
			mountData.flyingFrameCount = 1;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 1;
			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 1;
			mountData.idleFrameCount = 1;
			mountData.idleFrameDelay = 12;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode != 2)
			{
				mountData.textureWidth = mountData.backTexture.Width;
				mountData.textureHeight = mountData.backTexture.Height;
			}
		}

		public override void UpdateEffects(Player player)
		{
			SPlayer sPlayer = (SPlayer)player.GetModPlayer(mod, "SPlayer");
			sPlayer.drakomireMount = true;
		}
	}
}
