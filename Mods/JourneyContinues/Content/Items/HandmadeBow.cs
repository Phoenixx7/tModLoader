using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyContinues.Content.Items
{
    public class HandmadeBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HandmadeBow");
            Tooltip.SetDefault("Handmade bow made from a few sticks and string");
        }

        public override void SetDefaults()
        {
            Item.damage = 13;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 17;
            Item.height = 25;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 10;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = false;
            Item.useAmmo = AmmoID.Arrow;
            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 30;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddIngredient(ItemID.Cobweb, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}