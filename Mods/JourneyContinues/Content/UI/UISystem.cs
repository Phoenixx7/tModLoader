using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.UI;
using Terraria.ModLoader;

namespace JourneyContinues.Content.UI
{
    public class UISystem : ModSystem
    {
        internal MenuBar menuBar;
        private UserInterface _menuBar;

        public override void Load()
        {
            menuBar = new MenuBar();
            menuBar.Activate();
            _menuBar = new UserInterface();
            _menuBar.SetState(menuBar);

        }
        public override void UpdateUI(GameTime gameTime)
        {
            _menuBar?.Update(gameTime);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "Journey Continues: Button do be button-ing tho",
                    delegate
                    {
                        _menuBar.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }

        }
    }
}
