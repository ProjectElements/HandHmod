using Terraria.ModLoader;

namespace HandHmod
{
	public class HandHmod : Mod
	{
		public static HandHmod Instance;

		public HandHmod()
        {
			Instance = this;
        }

        public override void Load()
        {
            if (Instance == null || Instance != this)
            {
                Instance = this;
            }
        }
    }
}