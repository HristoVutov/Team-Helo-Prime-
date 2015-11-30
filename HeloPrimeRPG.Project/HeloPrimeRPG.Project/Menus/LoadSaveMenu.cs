
using HeloPrimeRPG.Model;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace HeloPrimeRPG.Project.Menus
{
    class LoadSaveMenu
    {

        monoButton characterButtonOne, characterButtonTwo, characterButtonThree;
        SpriteFont myFont;
        GameState gameState;

        public LoadSaveMenu(GameState gameState)
        {
            this.gameState = gameState;
        }




        public void LoadContent(ContentManager content, SpriteBatch spriteBatch)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            Texture2D texture;
            texture = content.Load<Texture2D>("Button");
            myFont = content.Load<SpriteFont>("myFont");

            characterButtonOne = new monoButton(texture, myFont, spriteBatch, "Create New Character", GameState.CreateCharacter);
            characterButtonTwo = new monoButton(texture, myFont, spriteBatch, "Create New Character", GameState.CreateCharacter);
            characterButtonThree = new monoButton(texture, myFont, spriteBatch, "Create New Character", GameState.CreateCharacter);

            // TODO: use this.Content to load your game content here
        }


        public void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        public GameState Update(GameState gameState)
        {


            characterButtonOne.Location(10, 10);
            characterButtonTwo.Location(10, 40);
            characterButtonThree.Location(10, 70);
            GameState gsOne = characterButtonOne.Update(gameState);
            GameState gsTwo = characterButtonOne.Update(gameState);
            GameState gsThree = characterButtonOne.Update(gameState);
            if (gameState != gsOne)
            {
                return gsOne;
            }
            if (gameState != gsTwo)
            {
                return gsTwo;
            }
            if (gameState != gsThree)
            {
                return gsThree;
            }

            return gameState;

        }

        public void Draw(SpriteBatch spriteBatch)
        {

            characterButtonOne.Draw();
            characterButtonTwo.Draw();
            characterButtonThree.Draw();

        }
    }
}
