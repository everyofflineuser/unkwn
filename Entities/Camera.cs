using Sparkle.CSharp.Entities;
using System.Numerics;
using Raylib_CSharp.Camera.Cam3D;
using Raylib_CSharp.Interact;

namespace unkwn.Entities;

public class Camera : Cam3D
{
    public Camera(Vector3 position, Vector3 target, Vector3 up, float fov = 90, CameraProjection projection = CameraProjection.Perspective, CameraMode mode = CameraMode.Free)
        : base(position, target, up, fov, projection, mode)
    {
        if (Mode == CameraMode.Free)
        {
            MouseSensitivity = 0.1f;
        }
    }

    protected override void Init()
    {
        base.Init();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }


    protected override void Update()
    {
        base.Update();

        if (Mode != CameraMode.Free && Input.IsMouseButtonDown(MouseButton.Right))
        {
            Mode = CameraMode.Free;
            Input.HideCursor();
            Input.DisableCursor();
        } else if (Mode != CameraMode.Custom && !Input.IsMouseButtonDown(MouseButton.Right))
        {
            Mode = CameraMode.Custom;
            Input.ShowCursor();
            Input.EnableCursor();
        }
    }
}