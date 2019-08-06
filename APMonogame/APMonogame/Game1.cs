﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace APMonogame
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Texture2D texture;
        //Vector2 position;
        //Rectangle drawRec;
        //float alpha = 1.0f;
        //float rotation = 1.0f;
        //Vector2 origin = new Vector2(0, 0);
        //float scale = 0.5f;
        //SpriteEffects spriteEffect = SpriteEffects.FlipHorizontally;
        //float zDepth = 0.1f;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        protected override void Initialize()
        {
            ScreenManager.Instance.Initialize();

            ScreenManager.Instance.Dimensions = new Vector2(800, 600);
            graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
            graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.IsMouseVisible = true;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //texture = Content.Load<Texture2D>(@"evilsonic");
            //drawRec = new Rectangle(0, 0, texture.Width, texture.Height);
            //position = new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 2);
            //origin = new Vector2(texture.Width / 2, texture.Height / 2);
            ScreenManager.Instance.LoadContent(Content);
        }
        protected override void UnloadContent() { }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) { Exit(); }
            ScreenManager.Instance.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            ScreenManager.Instance.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}