using Terraria.ID;
using Terraria.ModLoader;

namespace GoToBed.Items
{
	public class GoToBed : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Go To Bed"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Go To Bed.");
		}

		public override void SetDefaults() 
		{
			item.width = 410;
			item.height = 94;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}