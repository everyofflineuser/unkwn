using OpenTK.Graphics.Wgl;
using Raylib_cs;
using Sparkle.CSharp;
using Sparkle.CSharp.Content.Types;
using Sparkle.CSharp.IO.Configs.Json;
using Sparkle.CSharp.Rendering;
using Sparkle.CSharp.Rendering.Helpers;
using Sparkle.CSharp.Windowing;
using System.Numerics;
using System.Text.RegularExpressions;

namespace unkwn;
public class BaseGame : Game
{
    private string title;

    public BaseGame(GameSettings settings, string title = "unkwn") : base(settings) { this.title = title; }

    /// <summary>
    /// Used for Initializes objects.
    /// </summary>
    protected override void Init()
    {
        Logger.Info("Test MSG");
        Window.SetTitle(title);

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
        Window.SetTitle(title + $" | {Time.Fps} FPS");

        base.Draw();
    }
}