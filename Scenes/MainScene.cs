using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Geometry;
using Raylib_CSharp.Interact;
using Raylib_CSharp.Rendering;
using Sparkle.CSharp.Entities;
using Sparkle.CSharp.Physics.Dim3;
using Sparkle.CSharp.Scenes;
using System.Numerics;
using unkwn.Entities;

namespace unkwn.Scenes;
public class MainScene : Scene
{
    public MainScene(string name = "MainScene", SceneType type = SceneType.Scene3D, Simulation3D? settings = null) : base(name, type, settings)
    {
    }

    protected override void Init()
    {
        base.Init();

        Vector3 pos = new Vector3(10.0f, 10.0f, 10.0f);
        Camera cam3D = new Camera(pos, Vector3.Zero, Vector3.UnitY, 90, CameraProjection.Perspective, CameraMode.Free);
        this.AddEntity(cam3D);

        TestEntity testEntity = new TestEntity(new Vector3(0f,0f,0f));
        this.AddEntity(testEntity);
    }

    protected override void Draw()
    {

        //Graphics.DrawGrid(100, 1);

        base.Draw();
    }
}