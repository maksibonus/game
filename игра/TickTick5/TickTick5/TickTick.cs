using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using RamGecXNAControls;

class TickTick : GameEnvironment
{
    public static TickTick game = new TickTick();
    static void Main()
    {
<<<<<<< HEAD
        GameTests.TestManager.Initialize();
        TickTick game = new TickTick();
=======
>>>>>>> 7bbb3be79357107ad8eb991c36352a3bad4c31a3
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