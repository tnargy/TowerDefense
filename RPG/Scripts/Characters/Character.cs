﻿using Godot;
using System;

namespace RPG;

public abstract partial class Character : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] public AnimationPlayer AnimPlayerNode { get; private set; }
    [Export] public Sprite3D Sprite3DNode { get; private set; }
    [Export] public StateMachine StateMachineNode { get; private set; }

    public Vector2 direction = new();

    public void Flip()
    {
        bool isNotMovingHoriz = Velocity.X == 0;
        if (isNotMovingHoriz) { return; }

        bool isMovingLeft = Velocity.X < 0;
        Sprite3DNode.FlipH = isMovingLeft;
    }
}