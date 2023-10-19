using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Controls _controls;

    public static void Init(Player myPlayer)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };

        _controls.Game.SpawnCandy.performed += ctx =>
        {
            myPlayer.Candy();
        };

        _controls.Permanent.Enable();
    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UIMode()
    {
        _controls.UI.Enable();
        _controls.Game.Disable();
    }

    
}
