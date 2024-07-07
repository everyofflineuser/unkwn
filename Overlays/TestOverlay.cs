using Sparkle.CSharp.Overlays;
using Raylib_CSharp.Rendering;
using Raylib_CSharp.Colors;

namespace unkwn.Overlays;

public class TestOverlay : Overlay
{

    public TestOverlay(string name = "DefaultOverlay") : base(name) { }

    protected override void Init()
    {
        base.Init();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void AfterUpdate()
    {
        base.AfterUpdate();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void Draw() 
    {
        Graphics.DrawFPS(0,0);
        Graphics.DrawText("TEST TEXT", 0, 100, 26, Color.White);
    }
}
