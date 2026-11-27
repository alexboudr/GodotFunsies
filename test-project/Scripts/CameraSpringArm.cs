using Godot;
using System;

public partial class CameraSpringArm : SpringArm3D
{
	[Export] public float camSensitivity = 0.005f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Input.MouseMode = Input.MouseModeEnum.Captured;
	}

	// // Called every frame. 'delta' is the elapsed time since the previous frame.
	// public override void _Process(double delta)
	// {
	// 	if (@event is InputEventMouseMotion)
	// 	{
			
	// 	}
	// }

    public override void _UnhandledInput(InputEvent @event)
    {
		Vector3 camRotation = Rotation;

		if (@event is InputEventMouseMotion mouseMotion)
		{
			camRotation.Y -= mouseMotion.Relative.X * camSensitivity;
			camRotation.X -= mouseMotion.Relative.Y * camSensitivity;
		}

		Rotation = camRotation;
    }

}
