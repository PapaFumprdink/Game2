using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

[SelectionBase]
[DisallowMultipleComponent]
public sealed class PlayerInput : MonoBehaviour
{
    private Camera m_MainCamera;

    public PlayerControls Controls { get; private set; }
    public bool IsGamepadBinded { get; private set; }
    public InputUser BindedUser { get; private set; }
    public Vector2 LookVector
    {
        get
        {
            if (IsGamepadBinded)
            {
                return Controls.General.LookDirection.ReadValue<Vector2>();
            }
            else
            {
                Vector2 mousePosition = Mouse.current.position.ReadValue();
                Vector2 lookPosition = m_MainCamera.ScreenToWorldPoint(mousePosition);
                return lookPosition - (Vector2)transform.position;
            }
        }
    }

    private void Awake()
    {
        m_MainCamera = Camera.main;

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

    public void BindController (int controllerIndex)
    {
        if (controllerIndex >= 0 && controllerIndex < Gamepad.all.Count)
        {
            InputUser user = InputUser.PerformPairingWithDevice(Gamepad.all[controllerIndex]);
            user.AssociateActionsWithUser(Controls);

            IsGamepadBinded = true;
        }
    }

    public void UnbindController ()
    {
        BindedUser.UnpairDevicesAndRemoveUser();
        
        IsGamepadBinded = false;
    }
}
