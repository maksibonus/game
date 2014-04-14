using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using RamGecXNAControls;

class TickTick : GameEnvironment
{
    public static TickTick game = new TickTick();
    static void Main()
    {
<<<<<<< HEAD
=======
//<<<<<<< HEAD
>>>>>>> 22c863c66b99ab5c7a18498048e9070d4ea9bf2c
        //GameTests.TestManager.Initialize();
//=======
        GameTests.TestManager.Initialize();
//>>>>>>> 64fbed2b7a4a5ce3aefc58bbe199204b6b34fca4
        TickTick game = new TickTick();
        game.Run();
    }

    public TickTick()
    {
        Content.RootDirectory = "Content";
        this.IsMouseVisible = true;
    }

    protected override void LoadContent()
    {
        base.LoadContent();

        screen = new Point(1440, 825);//создание точки
        this.SetFullScreen(false);
        gameStateManager.AddGameState("titleMenu", new TitleMenuState());
        gameStateManager.AddGameState("helpState", new HelpState());
        gameStateManager.AddGameState("playingState", new PlayingState(Content));
        gameStateManager.AddGameState("levelMenu", new LevelMenuState());
        gameStateManager.AddGameState("gameOverState", new GameOverState());
        gameStateManager.AddGameState("levelFinishedState", new LevelFinishedState());
        gameStateManager.AddGameState("questionState", new QuestionState());
        gameStateManager.SwitchTo("titleMenu");

        //AssetManager.PlayMusic("Sounds/snd_music");
    }
}