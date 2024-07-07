using Sparkle.CSharp.Entities.Components;
using Sparkle.CSharp.Entities;
using System.Numerics;

namespace unkwn.Entities;

public class TestEntity : Entity
{
    public TestEntity(Vector3 position) : base(position) { }

    protected override void Init()
    {
        base.Init();

        // RENDERER
        ModelRenderer modelRenderer = new ModelRenderer(ContentRegistry.MapsPool["de_vertigo"], Vector3.Zero);
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