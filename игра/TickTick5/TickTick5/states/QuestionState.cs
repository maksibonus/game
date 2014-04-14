using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RamGecXNAControls;
using RamGecXNAControls.ExtendedControls;

class QuestionState: GameObjectList
{
    RamGecXNAControls.Window myWindow;
    RamGecXNAControls.Button myButton;
    RamGecXNAControls.GUIManager guiManager = new RamGecXNAControls.GUIManager(TickTick.game, "Themes", "Default");
    RamGecXNAControls.Label myLabel;

    public QuestionState()
    {
        // add a background
        //SpriteGameObject background = new SpriteGameObject("Backgrounds/spr_levelselect", 0, "background");
        //this.Add(background);
        //GameEnvironment.Screen.Y

        //створюємо вікно
        myWindow = new Window(new Rectangle(50, 50, 650, 650), "Hello!");
        guiManager.Controls.Add(myWindow);

        //створюємо кнопки
        myButton = new RamGecXNAControls.Button(new Rectangle(60,60,40,30), "Cancel");//(myWindow.AbsoluteBounds.Width / 2) - 40, (myWindow.AbsoluteBounds.Height / 2) - 30, 40, 30), "Відміна");
        myButton.Name = "Cancel";
        myButton.Parent = myWindow;
        myButton.OnClick += (sender) => { GameEnvironment.GameStateManager.SwitchTo("playingState"); };
        guiManager.Controls.Add(myButton);
    }

    //public override void HandleInput(InputHelper inputHelper)
    //{
    //    base.HandleInput(inputHelper);
    //    if (guiManager.GetControl("Cancel").Focused)
    //    {
    //        GameEnvironment.GameStateManager.SwitchTo("playingState");
    //    }
    //    else
    //    {
    //        GameEnvironment.GameStateManager.SwitchTo("questionState");
    //    }
    //}
    public override void Update(GameTime gameTime)
    {
        foreach (var control in guiManager.Controls)
            control.Update(gameTime);
        base.Update(gameTime);
    }
    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        foreach(var control in guiManager.Controls)
            control.Draw(spriteBatch);
        base.Draw(gameTime, spriteBatch);
    }
}

