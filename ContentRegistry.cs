using Raylib_CSharp.Geometry;
using Sparkle.CSharp.Content;
using Sparkle.CSharp.Content.Types;
using Sparkle.CSharp.Registries;

namespace unkwn;

public class ContentRegistry : Registry
{
    public static Dictionary<string, Model> MapsPool = new Dictionary<string, Model>();

    protected override void Load(ContentManager content)
    {
        base.Load(content);

        MapsPool.Add("de_vertigo", content.Load(new ModelContent("content/models/maps/de_vertigo.glb")));
    }
}