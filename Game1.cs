using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2_Scaling_and_text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture, rectTexture;
        Rectangle circleRect;


        SpriteFont TextFont;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            

            circleRect = new Rectangle(10, 100, 100, 50);

            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectTexture = Content.Load<Texture2D>("rectangle");
            TextFont = Content.Load<SpriteFont>("TextFont");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
           
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(circleTexture,circleRect, Color.Brown);
            _spriteBatch.Draw(rectTexture, new Rectangle(50, 150, 25, 75), Color.White);
            _spriteBatch.DrawString(TextFont, "Tony", new Vector2(250, 250), Color.Black);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
