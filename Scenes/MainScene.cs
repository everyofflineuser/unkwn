using Raylib_cs;
using Sparkle.CSharp.Entities;
using Sparkle.CSharp.Physics;
using Sparkle.CSharp.Rendering.Helpers;
using Sparkle.CSharp.Scenes;
using System.Numerics;

namespace unkwn.Scenes;
public class MainScene : Scene
{
    public MainScene(string name = "MainScene", SceneType type = SceneType.Scene3D, PhysicsSettings? settings = null) : base(name, type, settings)
    {
    }

    protected override void Init()
    {
        base.Init();

        Vector3 pos = new Vector3(10.0f, 10.0f, 10.0f);
        Cam3D cam3D = new Cam3D(pos, Vector3.Zero, Vector3.UnitY, 90, CameraProjection.Perspective, CameraMode.Orbital);
        this.AddEntity(cam3D);
    }

    protected override void Draw()
    {
        base.Draw();

        // BEGIN 3D
        SceneManager.MainCam3D!.BeginMode3D();

        //DRAW GIRD
        ModelHelper.DrawGrid(100, 1);

        // END 3D
        SceneManager.MainCam3D.EndMode3D();
    }
}