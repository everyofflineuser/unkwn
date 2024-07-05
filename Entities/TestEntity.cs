using Sparkle.CSharp.Entities.Components;
using Sparkle.CSharp.Entities;
using System.Numerics;
using Sparkle.CSharp.Rendering.Helpers;
using Sparkle.CSharp.Rendering.Util;

namespace unkwn.Entities;

public class TestEntity : Entity
{
    public TestEntity(Vector3 position) : base(position) { }

    protected override void Init()
    {
        base.Init();

        // RENDERER
        MaterialBuilder builder = new MaterialBuilder(BaseGame.MapModel);

        ModelRenderer modelRenderer = new ModelRenderer(BaseGame.MapModel, builder.Build());
        this.AddComponent(modelRenderer);
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    protected override void Update()
    {
        base.Update();
    }
}