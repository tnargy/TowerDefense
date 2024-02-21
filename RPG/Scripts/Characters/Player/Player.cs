using Godot;
using System;

public partial class Player : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] public AnimationPlayer AnimPlayerNode { get; private set; }
    [Export] public Sprite3D Sprite3DNode { get; private set; }
    [Export] public StateMachine StateMachineNode { get; private set; }

    public Vector2 direction = new();

    public override void _Ready() 
    {
    }

    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            GameConstants.INPUT_MOVE_LEFT, GameConstants.INPUT_MOVE_RIGHT, 
            GameConstants.INPUT_MOVE_FORWARD, GameConstants.INPUT_MOVE_BACKWARD    
        );
    }

    public void Flip()
    {
        bool isNotMovingHoriz = Velocity.X == 0;
        if (isNotMovingHoriz) { return; }

        bool isMovingLeft = Velocity.X < 0;
        Sprite3DNode.FlipH = isMovingLeft;
    }
}