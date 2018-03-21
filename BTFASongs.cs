using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.UI;
using Terraria.ModLoader;
using BTFASongs;

namespace BTFASongs
{
	class BTFASongs : Mod
	{
		//some code borrowed permanently from fargo to load data from other mods
        internal bool btfaLoaded;
        internal static BTFASongs instance;

		//BTFASongsGlobalNPC songsNPC = new BTFASongsGlobalNPC();
		
		public BTFASongs()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void Load()
        {
            instance = this;
        }
        
        public override void PostSetupContent()
        {
            try
            {
				btfaLoaded = ModLoader.GetMod("ForgottenMemories") != null;
            }
            catch (Exception e)
            {
                ErrorLogger.Log("BTFASongs PostSetupContent Error: " + e.StackTrace + e.Message);
            }
        }

		/*public string GetName(int i)
		{
			if (i == 0)
				return "out";
			if (i == 1)
				return "godofwar";
			if (i == 2)
				return "darknessthatchillsmenshearts";
			if (i == 3)
				return "out";

			return "out";
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if(Main.myPlayer != -1 && !Main.gameMenu)
			{
				int[] IDs = new int[4];

				for (int i = 0; i < 4; i++)
				{
					IDs[i] = songsNPC.ReturnID(i);
					if (IDs[i] >= 0) //check for respective bosses -> play corresponding song if active, reset ID if inactive
					{
						if (Main.npc[IDs[i]].active)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/" + GetName(i));
							priority = MusicPriority.BossHigh;
						}
						else
						{
							songsNPC.ResetID(i);
						}
					}
				}
			}
		}*/
	}
}
