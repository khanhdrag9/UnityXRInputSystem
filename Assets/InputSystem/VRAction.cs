// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/VRAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VRAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VRAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VRAction"",
    ""maps"": [
        {
            ""name"": ""VRLeftHand"",
            ""id"": ""ed544dae-979b-4568-95fd-b4162ea2922d"",
            ""actions"": [
                {
                    ""name"": ""SmoothMovement"",
                    ""type"": ""Value"",
                    ""id"": ""b1cd7c94-c81a-4616-8e59-1e16fc142261"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26943843-384b-4ec2-81d0-d12943a13515"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9ff104fc-f46d-42ba-ac1a-dd347574cb33"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""18687332-f970-4b5d-b8e2-5ffb078b4d96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1e002907-5382-4b3b-85c3-90d67533cad0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c11985fe-a126-4a18-a1fa-8900fa97c540"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""50bc3a69-3218-4041-8e03-3d213f5fce58"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bbbb9c9c-69d2-4a21-a817-238704cdb192"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""VRRightHand"",
            ""id"": ""5604e1da-7cd8-4028-ae8d-208c210c5d5c"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""704192ac-7fed-411f-9d9c-8da2f3823796"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1cc489c9-d417-4b69-a6c4-6c10ec878d06"",
                    ""path"": ""<XRController>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(y=0)"",
                    ""groups"": ""VR Generic"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b01ad3d-a4e5-4ef0-a214-f48837427b0e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.25,y=0.25)"",
                    ""groups"": ""PC Generic"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93c9f094-ffe4-40d3-ab69-006cb1b7aac6"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""VR Generic"",
            ""bindingGroup"": ""VR Generic"",
            ""devices"": []
        },
        {
            ""name"": ""PC Generic"",
            ""bindingGroup"": ""PC Generic"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller Generic"",
            ""bindingGroup"": ""Controller Generic"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // VRLeftHand
        m_VRLeftHand = asset.FindActionMap("VRLeftHand", throwIfNotFound: true);
        m_VRLeftHand_SmoothMovement = m_VRLeftHand.FindAction("SmoothMovement", throwIfNotFound: true);
        // VRRightHand
        m_VRRightHand = asset.FindActionMap("VRRightHand", throwIfNotFound: true);
        m_VRRightHand_Rotation = m_VRRightHand.FindAction("Rotation", throwIfNotFound: true);
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

    // VRLeftHand
    private readonly InputActionMap m_VRLeftHand;
    private IVRLeftHandActions m_VRLeftHandActionsCallbackInterface;
    private readonly InputAction m_VRLeftHand_SmoothMovement;
    public struct VRLeftHandActions
    {
        private @VRAction m_Wrapper;
        public VRLeftHandActions(@VRAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @SmoothMovement => m_Wrapper.m_VRLeftHand_SmoothMovement;
        public InputActionMap Get() { return m_Wrapper.m_VRLeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VRLeftHandActions set) { return set.Get(); }
        public void SetCallbacks(IVRLeftHandActions instance)
        {
            if (m_Wrapper.m_VRLeftHandActionsCallbackInterface != null)
            {
                @SmoothMovement.started -= m_Wrapper.m_VRLeftHandActionsCallbackInterface.OnSmoothMovement;
                @SmoothMovement.performed -= m_Wrapper.m_VRLeftHandActionsCallbackInterface.OnSmoothMovement;
                @SmoothMovement.canceled -= m_Wrapper.m_VRLeftHandActionsCallbackInterface.OnSmoothMovement;
            }
            m_Wrapper.m_VRLeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SmoothMovement.started += instance.OnSmoothMovement;
                @SmoothMovement.performed += instance.OnSmoothMovement;
                @SmoothMovement.canceled += instance.OnSmoothMovement;
            }
        }
    }
    public VRLeftHandActions @VRLeftHand => new VRLeftHandActions(this);

    // VRRightHand
    private readonly InputActionMap m_VRRightHand;
    private IVRRightHandActions m_VRRightHandActionsCallbackInterface;
    private readonly InputAction m_VRRightHand_Rotation;
    public struct VRRightHandActions
    {
        private @VRAction m_Wrapper;
        public VRRightHandActions(@VRAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_VRRightHand_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_VRRightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VRRightHandActions set) { return set.Get(); }
        public void SetCallbacks(IVRRightHandActions instance)
        {
            if (m_Wrapper.m_VRRightHandActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_VRRightHandActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_VRRightHandActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_VRRightHandActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_VRRightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public VRRightHandActions @VRRightHand => new VRRightHandActions(this);
    private int m_VRGenericSchemeIndex = -1;
    public InputControlScheme VRGenericScheme
    {
        get
        {
            if (m_VRGenericSchemeIndex == -1) m_VRGenericSchemeIndex = asset.FindControlSchemeIndex("VR Generic");
            return asset.controlSchemes[m_VRGenericSchemeIndex];
        }
    }
    private int m_PCGenericSchemeIndex = -1;
    public InputControlScheme PCGenericScheme
    {
        get
        {
            if (m_PCGenericSchemeIndex == -1) m_PCGenericSchemeIndex = asset.FindControlSchemeIndex("PC Generic");
            return asset.controlSchemes[m_PCGenericSchemeIndex];
        }
    }
    private int m_ControllerGenericSchemeIndex = -1;
    public InputControlScheme ControllerGenericScheme
    {
        get
        {
            if (m_ControllerGenericSchemeIndex == -1) m_ControllerGenericSchemeIndex = asset.FindControlSchemeIndex("Controller Generic");
            return asset.controlSchemes[m_ControllerGenericSchemeIndex];
        }
    }
    public interface IVRLeftHandActions
    {
        void OnSmoothMovement(InputAction.CallbackContext context);
    }
    public interface IVRRightHandActions
    {
        void OnRotation(InputAction.CallbackContext context);
    }
}
