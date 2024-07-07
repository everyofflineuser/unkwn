using Sparkle.CSharp.GUI.Elements.Data;
using Sparkle.CSharp.GUI.Elements;
using Sparkle.CSharp.GUI;
using System.Numerics;
using Raylib_CSharp.Fonts;
using Raylib_CSharp.Colors;

namespace unkwn.GUI;

public class TestGUI : Gui
{

    public TestGUI(string name = "DefaultGUI") : base(name) { }

    protected override void Init()
    {
        base.Init();

        LabelData labelData = new LabelData()
        {
            Font = Font.GetDefault(),
            FontSize = 50,
            Spacing = 4,
            Text = "LABEL!",
            Color = Color.White,
            HoverColor = Color.Gray,
            Rotation = 0
        };

        this.AddElement(new LabelElement("name", labelData, Anchor.Center, Vector2.Zero));

        // ADD MORE ELEMENTS HERE:
    }
}