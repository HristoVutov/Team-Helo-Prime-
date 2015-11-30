using HeloPrimeRPG.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Project
{
    class MainMenu 
    {

        monoButton button;
        SpriteFont myFont;
        GameState gameState;

        public MainMenu(GameState gameState)
        {
            this.gameState = gameState;
        }

        

        
        public void LoadContent(ContentManager content,SpriteBatch spriteBatch)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            Texture2D texture;
            texture = content.Load<Texture2D>("Button");
            myFont = content.Load<SpriteFont>("myFont");

            button = new monoButton(texture, myFont, spriteBatch, "play",GameState.Play);

            // TODO: use this.Content to load your game content here
        }

        
        public void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        public GameState Update(GameState gameState)
        {
            

            button.Location(10, 10);
            GameState gs = button.Update(gameState);

            return gs;
            
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {

            button.Draw();
            
        }
    }
}
