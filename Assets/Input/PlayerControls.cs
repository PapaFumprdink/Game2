// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""71136618-0bef-4da9-8f87-e97be9829380"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""11db9a32-7c15-4559-b70b-ee829dc6ee79"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c7bdc6be-2bc2-4379-af90-fbddff45cb15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look Direction"",
                    ""type"": ""Button"",
                    ""id"": ""e0766aed-f200-4846-9252-c61d8fd24e5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""bfe3eaa6-0b0c-4afc-b35d-0dc4ad134eb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""da02fbf1-33d3-4f14-994f-2138ad2c0de9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""e7aef4ab-e136-4e12-a90b-9c5b338e0a7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0bb11520-dae0-442f-882c-f7c56ce6a643"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ac24ffab-234b-4f54-b067-b7394ded626e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9d9ebb12-73ff-4a39-8acd-4d2e24cbece9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cfe4daac-9524-445a-9a1c-d9a949911701"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bf6dead6-7225-435d-8343-b7c787663469"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1c4fddc0-7dae-4b04-a946-d4bbd6b90b4e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e096a4c-5370-4930-ab36-55d70f2a8d2f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23910304-a031-4713-9ec6-7cbfe2d217cc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8505323b-9634-4698-93a8-cbf63dfe76da"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccbf90e0-ed85-42e3-ac7f-48280736ed10"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_Movement = m_General.FindAction("Movement", throwIfNotFound: true);
        m_General_Jump = m_General.FindAction("Jump", throwIfNotFound: true);
        m_General_LookDirection = m_General.FindAction("Look Direction", throwIfNotFound: true);
        m_General_Shoot = m_General.FindAction("Shoot", throwIfNotFound: true);
        m_General_Throw = m_General.FindAction("Throw", throwIfNotFound: true);
        m_General_Crouch = m_General.FindAction("Crouch", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_Movement;
    private readonly InputAction m_General_Jump;
    private readonly InputAction m_General_LookDirection;
    private readonly InputAction m_General_Shoot;
    private readonly InputAction m_General_Throw;
    private readonly InputAction m_General_Crouch;
    public struct GeneralActions
    {
        private @PlayerControls m_Wrapper;
        public GeneralActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_General_Movement;
        public InputAction @Jump => m_Wrapper.m_General_Jump;
        public InputAction @LookDirection => m_Wrapper.m_General_LookDirection;
        public InputAction @Shoot => m_Wrapper.m_General_Shoot;
        public InputAction @Throw => m_Wrapper.m_General_Throw;
        public InputAction @Crouch => m_Wrapper.m_General_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnJump;
                @LookDirection.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnLookDirection;
                @LookDirection.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnLookDirection;
                @LookDirection.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnLookDirection;
                @Shoot.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnShoot;
                @Throw.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnThrow;
                @Crouch.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnCrouch;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LookDirection.started += instance.OnLookDirection;
                @LookDirection.performed += instance.OnLookDirection;
                @LookDirection.canceled += instance.OnLookDirection;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);
    public interface IGeneralActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLookDirection(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnThrow(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
}
