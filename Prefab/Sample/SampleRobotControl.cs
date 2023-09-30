using Godot;
using System;

[Tool]
public partial class SampleRobotControl : Node
{

    [Export]
    public SampleRobot sampleRobot;

    [Export]
    public Node3D target;

    [Export]
    public Node3D hold;

    public override void _Process(double delta)
    {
        if (sampleRobot is not null && target is not null)
        {
            sampleRobot.SetInverse(target.Transform.Origin);
        }
        if (sampleRobot is not null && hold is not null)
        {
            hold.Transform = new Transform3D(Basis.Identity, sampleRobot.CurrentPosition());
        }
    }
}
