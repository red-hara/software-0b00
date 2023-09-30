using Godot;
using System;

public partial class SampleTarget : MeshInstance3D
{
    private float counter = 0;

    public override void _Process(double delta)
    {
        counter += (float)delta;

        var pose = new Vector3(1, 0, 0.75f) + new Basis(new Vector3(1, 0, 0), counter) * new Vector3(0, 0.5f, 0);
        Transform = new Transform3D(Basis.Identity, pose);
    }
}
