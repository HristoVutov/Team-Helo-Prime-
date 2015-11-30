using HeloPrimeRPG.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HeloPrimeRPG.Project
{
    public class monoButton
    {
        Texture2D image;
        SpriteFont font;
        Rectangle location;
        string text;
        string buttonText;
        Vector2 textLocation;
        SpriteBatch spriteBatch;
        MouseState mouse;
        MouseState oldMouse;
        bool clicked = false;
        string clickText = "Button was Clicked!";
        GameState buttonState;

        public monoButton(Texture2D texture, SpriteFont font, SpriteBatch sBatch,string text,GameState buttonState)
        {
            buttonText = text;
            image = texture;
            this.font = font;
            location = new Rectangle(0, 0, 100, 20);
            spriteBatch = sBatch;
            this.buttonState = buttonState;
            this.text = text;
        }

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                Vector2 size = font.MeasureString(text);
                textLocation = new Vector2();
                textLocation.Y = location.Y ;
                textLocation.X = location.X ;
            }
        }

        public void Location(int x, int y)
        {
            location.X = x;
            location.Y = y;
        }

        public GameState Update(GameState gameState)
        {
            mouse = Mouse.GetState();

            if (mouse.LeftButton == ButtonState.Released && oldMouse.LeftButton == ButtonState.Pressed)
            {
                if (location.Contains(new Point(mouse.X, mouse.Y)))
                {
                    clicked = true;
                    return this.buttonState;
                }
            }

            Text = this.buttonText;
            oldMouse = mouse;

            return gameState;
        }

        public void Draw()
        {
            spriteBatch.Begin();

            if (location.Contains(new Point(mouse.X, mouse.Y)))
            {
                spriteBatch.Draw(image,
                    location,
                    Color.Silver);
            }
            else
            {
                spriteBatch.Draw(image,
                    location,
                    Color.White);
            }

            spriteBatch.DrawString(font,
                text,
                textLocation,
                Color.Black);

            

            spriteBatch.End();
        }
    }
}
