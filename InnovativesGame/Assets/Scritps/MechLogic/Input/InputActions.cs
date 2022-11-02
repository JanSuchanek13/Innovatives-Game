//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Scritps/MechLogic/Input/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""LowerBody"",
            ""id"": ""47627e12-f72c-49dc-b1c5-bc8ff8f68dee"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ece5324e-cd88-414f-abd5-4b18c2fc1b9a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""cefd0f6b-c579-4bee-a198-856494b8e89d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ActivateDebuff_1"",
                    ""type"": ""Button"",
                    ""id"": ""4995f056-cd06-4cd6-80ea-48bdac9a6188"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateDebuff_2"",
                    ""type"": ""Button"",
                    ""id"": ""29775135-916b-44be-8965-2f2dba5d4832"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateDebuff_3"",
                    ""type"": ""Button"",
                    ""id"": ""4b68c15e-95d0-44c8-a360-5898aefee6ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f0152cb3-32d9-4afc-9d82-bdd2078477f2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""13498053-c590-43b2-a9b9-c069c60a95cb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""161ce0cc-91e8-4740-bbcd-9ee87886147c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""10d2665d-b690-4eff-89cc-574d4c666438"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7c0eed16-1062-46c3-8839-5218347c93db"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ARROW-KEYS"",
                    ""id"": ""36d73b81-262a-484a-b8c4-f61f4fc58890"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f8608abe-830e-441a-9731-26d538d81aa5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5546aeff-e2d4-4811-a1f1-0eed4dca4f84"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ce796729-81e5-4f22-be2d-a1c2c94bfb98"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c297219d-9bb1-4bf6-89ae-917abfe949b7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""38bfba4c-14a2-4497-8abf-f57bcb6b2793"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaeca592-2994-4d60-9b7b-61182010f0ab"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b03850a6-9b09-4704-9314-2052e3a536f7"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91c89f54-cd12-45f8-b48b-065250c525f7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f945217-887f-448a-9db9-a84e5c1ad465"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fd74f08-3fbf-478f-8566-7efe9e99ccf2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a08246d-353f-4273-84a7-91a732700ad4"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd27e999-a787-4f07-9a44-947e4e0954a1"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UpperBody"",
            ""id"": ""b7bb4a55-1dbd-4e84-b4b0-994b5f3b8ff9"",
            ""actions"": [
                {
                    ""name"": ""TurretRotation"",
                    ""type"": ""Value"",
                    ""id"": ""36cb6fb6-0993-47e7-a26a-b7bcaea716e3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot_LeftWeapon(1)"",
                    ""type"": ""Button"",
                    ""id"": ""a277907e-6349-46fd-90e8-1abdd59b8576"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot_RightWeapon(2)"",
                    ""type"": ""Button"",
                    ""id"": ""8e0065b8-b69a-4919-b624-b4fbf23ed47c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateDebuff_1"",
                    ""type"": ""Button"",
                    ""id"": ""bd8be85b-7a47-44e6-85d9-6667491276a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateDebuff_2"",
                    ""type"": ""Button"",
                    ""id"": ""d3f84b45-73fa-40a6-90a9-2acff0dbd3e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ActivateDebuff_3"",
                    ""type"": ""Button"",
                    ""id"": ""04be10e9-1086-4a33-961a-f8bf6bbdab50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a58efdb4-9fb4-47f0-b262-207fdda5a642"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e73b2c3f-bce0-4d37-aa49-ea3cd3ecfed3"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a63017e-93cb-477d-b060-135f5fd7db21"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot_LeftWeapon(1)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d279a6b2-705e-4916-8cf5-3d123d25c8f4"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot_LeftWeapon(1)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51655f92-ebc7-4c56-8112-440b0eb45380"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.03,y=0.03)"",
                    ""groups"": """",
                    ""action"": ""TurretRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17343b6b-943d-4cfa-a028-2186d4fa26d9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TurretRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f52b3f13-4e50-41a5-b02c-3b55cd607bbb"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d09b0373-3d99-45a6-a53d-2243759259e1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fc5c7f2-1e84-461d-89e4-31c9e8ad9488"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96ad6529-44da-4347-b548-efbba72dcb84"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActivateDebuff_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc76ff1a-9b64-491b-9722-70de7cb6bfa8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot_RightWeapon(2)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b22d0eb6-7fa9-4ab5-963c-39f0abda988d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot_RightWeapon(2)"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LowerBody
        m_LowerBody = asset.FindActionMap("LowerBody", throwIfNotFound: true);
        m_LowerBody_Move = m_LowerBody.FindAction("Move", throwIfNotFound: true);
        m_LowerBody_Sprint = m_LowerBody.FindAction("Sprint", throwIfNotFound: true);
        m_LowerBody_ActivateDebuff_1 = m_LowerBody.FindAction("ActivateDebuff_1", throwIfNotFound: true);
        m_LowerBody_ActivateDebuff_2 = m_LowerBody.FindAction("ActivateDebuff_2", throwIfNotFound: true);
        m_LowerBody_ActivateDebuff_3 = m_LowerBody.FindAction("ActivateDebuff_3", throwIfNotFound: true);
        // UpperBody
        m_UpperBody = asset.FindActionMap("UpperBody", throwIfNotFound: true);
        m_UpperBody_TurretRotation = m_UpperBody.FindAction("TurretRotation", throwIfNotFound: true);
        m_UpperBody_Shoot_LeftWeapon1 = m_UpperBody.FindAction("Shoot_LeftWeapon(1)", throwIfNotFound: true);
        m_UpperBody_Shoot_RightWeapon2 = m_UpperBody.FindAction("Shoot_RightWeapon(2)", throwIfNotFound: true);
        m_UpperBody_ActivateDebuff_1 = m_UpperBody.FindAction("ActivateDebuff_1", throwIfNotFound: true);
        m_UpperBody_ActivateDebuff_2 = m_UpperBody.FindAction("ActivateDebuff_2", throwIfNotFound: true);
        m_UpperBody_ActivateDebuff_3 = m_UpperBody.FindAction("ActivateDebuff_3", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // LowerBody
    private readonly InputActionMap m_LowerBody;
    private ILowerBodyActions m_LowerBodyActionsCallbackInterface;
    private readonly InputAction m_LowerBody_Move;
    private readonly InputAction m_LowerBody_Sprint;
    private readonly InputAction m_LowerBody_ActivateDebuff_1;
    private readonly InputAction m_LowerBody_ActivateDebuff_2;
    private readonly InputAction m_LowerBody_ActivateDebuff_3;
    public struct LowerBodyActions
    {
        private @InputActions m_Wrapper;
        public LowerBodyActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_LowerBody_Move;
        public InputAction @Sprint => m_Wrapper.m_LowerBody_Sprint;
        public InputAction @ActivateDebuff_1 => m_Wrapper.m_LowerBody_ActivateDebuff_1;
        public InputAction @ActivateDebuff_2 => m_Wrapper.m_LowerBody_ActivateDebuff_2;
        public InputAction @ActivateDebuff_3 => m_Wrapper.m_LowerBody_ActivateDebuff_3;
        public InputActionMap Get() { return m_Wrapper.m_LowerBody; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LowerBodyActions set) { return set.Get(); }
        public void SetCallbacks(ILowerBodyActions instance)
        {
            if (m_Wrapper.m_LowerBodyActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnMove;
                @Sprint.started -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnSprint;
                @ActivateDebuff_1.started -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_1;
                @ActivateDebuff_1.performed -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_1;
                @ActivateDebuff_1.canceled -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_1;
                @ActivateDebuff_2.started -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_2;
                @ActivateDebuff_2.performed -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_2;
                @ActivateDebuff_2.canceled -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_2;
                @ActivateDebuff_3.started -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_3;
                @ActivateDebuff_3.performed -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_3;
                @ActivateDebuff_3.canceled -= m_Wrapper.m_LowerBodyActionsCallbackInterface.OnActivateDebuff_3;
            }
            m_Wrapper.m_LowerBodyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @ActivateDebuff_1.started += instance.OnActivateDebuff_1;
                @ActivateDebuff_1.performed += instance.OnActivateDebuff_1;
                @ActivateDebuff_1.canceled += instance.OnActivateDebuff_1;
                @ActivateDebuff_2.started += instance.OnActivateDebuff_2;
                @ActivateDebuff_2.performed += instance.OnActivateDebuff_2;
                @ActivateDebuff_2.canceled += instance.OnActivateDebuff_2;
                @ActivateDebuff_3.started += instance.OnActivateDebuff_3;
                @ActivateDebuff_3.performed += instance.OnActivateDebuff_3;
                @ActivateDebuff_3.canceled += instance.OnActivateDebuff_3;
            }
        }
    }
    public LowerBodyActions @LowerBody => new LowerBodyActions(this);

    // UpperBody
    private readonly InputActionMap m_UpperBody;
    private IUpperBodyActions m_UpperBodyActionsCallbackInterface;
    private readonly InputAction m_UpperBody_TurretRotation;
    private readonly InputAction m_UpperBody_Shoot_LeftWeapon1;
    private readonly InputAction m_UpperBody_Shoot_RightWeapon2;
    private readonly InputAction m_UpperBody_ActivateDebuff_1;
    private readonly InputAction m_UpperBody_ActivateDebuff_2;
    private readonly InputAction m_UpperBody_ActivateDebuff_3;
    public struct UpperBodyActions
    {
        private @InputActions m_Wrapper;
        public UpperBodyActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TurretRotation => m_Wrapper.m_UpperBody_TurretRotation;
        public InputAction @Shoot_LeftWeapon1 => m_Wrapper.m_UpperBody_Shoot_LeftWeapon1;
        public InputAction @Shoot_RightWeapon2 => m_Wrapper.m_UpperBody_Shoot_RightWeapon2;
        public InputAction @ActivateDebuff_1 => m_Wrapper.m_UpperBody_ActivateDebuff_1;
        public InputAction @ActivateDebuff_2 => m_Wrapper.m_UpperBody_ActivateDebuff_2;
        public InputAction @ActivateDebuff_3 => m_Wrapper.m_UpperBody_ActivateDebuff_3;
        public InputActionMap Get() { return m_Wrapper.m_UpperBody; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UpperBodyActions set) { return set.Get(); }
        public void SetCallbacks(IUpperBodyActions instance)
        {
            if (m_Wrapper.m_UpperBodyActionsCallbackInterface != null)
            {
                @TurretRotation.started -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnTurretRotation;
                @TurretRotation.performed -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnTurretRotation;
                @TurretRotation.canceled -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnTurretRotation;
                @Shoot_LeftWeapon1.started -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnShoot_LeftWeapon1;
                @Shoot_LeftWeapon1.performed -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnShoot_LeftWeapon1;
                @Shoot_LeftWeapon1.canceled -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnShoot_LeftWeapon1;
                @Shoot_RightWeapon2.started -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnShoot_RightWeapon2;
                @Shoot_RightWeapon2.performed -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnShoot_RightWeapon2;
                @Shoot_RightWeapon2.canceled -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnShoot_RightWeapon2;
                @ActivateDebuff_1.started -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_1;
                @ActivateDebuff_1.performed -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_1;
                @ActivateDebuff_1.canceled -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_1;
                @ActivateDebuff_2.started -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_2;
                @ActivateDebuff_2.performed -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_2;
                @ActivateDebuff_2.canceled -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_2;
                @ActivateDebuff_3.started -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_3;
                @ActivateDebuff_3.performed -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_3;
                @ActivateDebuff_3.canceled -= m_Wrapper.m_UpperBodyActionsCallbackInterface.OnActivateDebuff_3;
            }
            m_Wrapper.m_UpperBodyActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TurretRotation.started += instance.OnTurretRotation;
                @TurretRotation.performed += instance.OnTurretRotation;
                @TurretRotation.canceled += instance.OnTurretRotation;
                @Shoot_LeftWeapon1.started += instance.OnShoot_LeftWeapon1;
                @Shoot_LeftWeapon1.performed += instance.OnShoot_LeftWeapon1;
                @Shoot_LeftWeapon1.canceled += instance.OnShoot_LeftWeapon1;
                @Shoot_RightWeapon2.started += instance.OnShoot_RightWeapon2;
                @Shoot_RightWeapon2.performed += instance.OnShoot_RightWeapon2;
                @Shoot_RightWeapon2.canceled += instance.OnShoot_RightWeapon2;
                @ActivateDebuff_1.started += instance.OnActivateDebuff_1;
                @ActivateDebuff_1.performed += instance.OnActivateDebuff_1;
                @ActivateDebuff_1.canceled += instance.OnActivateDebuff_1;
                @ActivateDebuff_2.started += instance.OnActivateDebuff_2;
                @ActivateDebuff_2.performed += instance.OnActivateDebuff_2;
                @ActivateDebuff_2.canceled += instance.OnActivateDebuff_2;
                @ActivateDebuff_3.started += instance.OnActivateDebuff_3;
                @ActivateDebuff_3.performed += instance.OnActivateDebuff_3;
                @ActivateDebuff_3.canceled += instance.OnActivateDebuff_3;
            }
        }
    }
    public UpperBodyActions @UpperBody => new UpperBodyActions(this);
    public interface ILowerBodyActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnActivateDebuff_1(InputAction.CallbackContext context);
        void OnActivateDebuff_2(InputAction.CallbackContext context);
        void OnActivateDebuff_3(InputAction.CallbackContext context);
    }
    public interface IUpperBodyActions
    {
        void OnTurretRotation(InputAction.CallbackContext context);
        void OnShoot_LeftWeapon1(InputAction.CallbackContext context);
        void OnShoot_RightWeapon2(InputAction.CallbackContext context);
        void OnActivateDebuff_1(InputAction.CallbackContext context);
        void OnActivateDebuff_2(InputAction.CallbackContext context);
        void OnActivateDebuff_3(InputAction.CallbackContext context);
    }
}