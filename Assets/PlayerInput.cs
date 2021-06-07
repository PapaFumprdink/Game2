using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
[DisallowMultipleComponent]
public sealed class PlayerInput : MonoBehaviour
{
    public PlayerControls Controls { get; private set; }

    private void Awake()
    {
        Controls = new PlayerControls();
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }
}
