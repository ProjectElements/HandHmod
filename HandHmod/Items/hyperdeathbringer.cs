using HandHmod.Items.hellfirefrag;
using Terraria.ID;
using Terraria.ModLoader;

namespace HandHmod.Items
{
	public class hyperdeathbringer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("H-striker"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A blade forged from the very essence of heaven and hell.");
		}

		public override void SetDefaults() 
		{
			item.damage = 67439;
			item.melee = true;
			item.width = 900;
			item.height = 900;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6743;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarOre, 999);
			recipe.AddIngredient(ModContent.ItemType<hellfirebar>(), 999);
			 recipe.AddIngredient(ModContent.ItemType<HeavenFlame.HeavenFlameBar>(), 999);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}