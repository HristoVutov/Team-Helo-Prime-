
using HeloPrimeRPG.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace HeloPrimeRPG.Project.Menus
{
    public class Map
    {
        private static int tileWidth = 54;
        private static int tileHeigh = 35;
        static int displayWidthTiles = (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height) / tileWidth;
        static int displayHeighTiles = (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height) / tileHeigh;
        private int[,,] map = new int[8, tileHeigh, tileWidth];
        private string[] type = new string[8];
        private int[,,] mapToShow;
        bool load = true;
        bool first = true;
        private int x, y;

        Dictionary<int, Dictionary<Vector2, Texture2D>> mapDict = new Dictionary<int, Dictionary<Vector2, Texture2D>>();
        int counter = 0;
        SpriteFont myFont;
        GameState gameState;
        SpriteBatch spriteBatch;

        public Map(GameState gameState)
        {
            this.gameState = gameState;
            this.spriteBatch = spriteBatch;
        }


        public void LoadMap(string type,int[,] matrix)
        {
            for (int i = 0; i < tileHeigh; i++)
            {
                for (int j = 0; j < tileWidth; j++)
                {
                    this.map[this.counter, i, j] = matrix[i, j];
                }
            }

            this.type[counter] = type;
            this.counter++;
        }

        public void SetMap(int x,int y)
        {
            if (this.x == x && this.y == y&&first==false)
            {
                load = false;
                return;
            }
            first = false;
            load = true;
            mapToShow = new int[8, displayHeighTiles,displayWidthTiles];
            for (int k = 0; k < 8; k++)
            {
                for (int i = y; i < y+displayHeighTiles; i++)
               {
                    for (int j = x; j < x+displayWidthTiles; j++)
                    {
                   
                        this.mapToShow[k,i-y, j-x] = 1+(map[k, j, i]);
                    }
                }

            }
        }

        public void LoadContent(ContentManager content, SpriteBatch spriteBatch)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            if (load == false)
            {
                return;
            }
            Texture2D texture;
            for (int i = 0; i < 8; i++)
            {
                
                for (int j = 0; j < displayHeighTiles; j++)
                {
                    for (int k = 0; k < displayWidthTiles; k++)
                    {
                        if(mapToShow[i, j, k] == 0)
                        {
                            continue;
                        }
                        texture = content.Load<Texture2D>("Tiles/" + type[i] + "_" + (mapToShow[i, j, k]));
                        Vector2 location = new Vector2(j * 32, k * 32);

                        if (!mapDict.ContainsKey(i))
                        {
                            Dictionary<Vector2, Texture2D> textures = new Dictionary<Vector2, Texture2D>();
                            textures.Add(location, texture);
                            mapDict.Add(i, textures);
                        }
                        else
                        {
                            mapDict[i].Add(location, texture);
                        }
                    }
                }
                
            }
            // TODO: use this.Content to load your game content here
        }


        public void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        public void Update(GameState gameState)
        {


           
            

        }

        public void Draw(SpriteBatch spriteBatch,ContentManager content)
        {

            
            foreach (var layer in mapDict)
            {
                foreach (var tile in layer.Value)
                {
                    spriteBatch.Begin();
                    spriteBatch.Draw(tile.Value, tile.Key);
                    spriteBatch.End();
                }
            }
            
        }
    }
}
