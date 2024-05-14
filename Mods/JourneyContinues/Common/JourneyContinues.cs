using JourneyContinues.Content.UI;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria;
using Terraria.UI;


namespace JourneyContinues.Common
{
	public class JourneyContinues : Mod
	{
        internal UserInterface MyInterface;
        internal TheUI MyUI;

        public override void Load()
        {
            base.Load();
            if (!Main.dedServ)
            {
                MyInterface = new UserInterface();

                MyUI = new TheUI();
                MyUI.Activate(); // Activate calls Initialize() on the UIState if not initialized, then calls OnActivate and then calls Activate on every child element
            }

        }

        private GameTime _lastUpdateUiGameTime;

        public override void UpdateUI(GameTime gameTime)
        {
            _lastUpdateUiGameTime = gameTime;
            if (MyInterface?.CurrentState != null)
            {
                MyInterface.Update(gameTime);
            }
        }

    }
}