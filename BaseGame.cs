using Raylib_CSharp;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Windowing;
using Sparkle.CSharp;
using Sparkle.CSharp.Logging;
using Sparkle.CSharp.Overlays;
using Sparkle.CSharp.Registries;
using unkwn.Overlays;

namespace unkwn;
public class BaseGame : Game
{
    private string _title;

    public BaseGame(GameSettings settings, string title = "unkwn") : base(settings) { this._title = title; }

    protected override void OnRun()
    {
        base.OnRun();
        RegistryManager.AddType(new ContentRegistry());
    }

    /// <summary>
    /// Used for Initializes objects.
    /// </summary>
    protected override void Init()
    {
        //Logger.Info("Test MSG");
        Window.SetTitle(_title);
        //GuiManager.SetGui(new TestGUI());

        TestOverlay myOverlay = new TestOverlay();
        myOverlay.Enabled = true;
         OverlayManager.Add(myOverlay);

        base.Init();
    }

    /// <summary>
    /// Used for loading resources.
    /// </summary>
    protected override void Load()
    {
        base.Load();
    }

    /// <summary>
    /// Is invoked during each tick and is used for updating dynamic elements and game logic.
    /// </summary>
    protected override void Update()
    {
        Window.SetTitle(_title + $" | {Time.GetFPS()} FPS");

        base.Update();
    }

    /// <summary>
    /// Called after the Update method on each tick to further update dynamic elements and game logic.
    /// </summary>
    protected override void AfterUpdate()
    {
        base.AfterUpdate();
    }

    /// <summary>
    /// Is invoked at a fixed rate of every <see cref="GameSettings.FixedTimeStep"/> frames following the <see cref="AfterUpdate"/> method.
    /// It is used for handling physics and other fixed-time operations.
    /// </summary>
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    /// <summary>
    /// Is called every tick, used for rendering stuff.
    /// </summary>
    protected override void Draw()
    {
        //_frames++;

        base.Draw();
    }
}