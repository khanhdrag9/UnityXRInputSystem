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
            ""name"": ""VRHead"",
            ""id"": ""75b48ca3-7db5-46fd-8c6a-f49b86ca8aeb"",
            ""actions"": [
                {
                    ""name"": ""RotationVR"",
                    ""type"": ""Value"",
                    ""id"": ""e4e77671-b798-41ba-a4ee-3a262bb620c6"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d4c500bd-7b97-4db3-beef-38c703ee6cee"",
                    ""path"": ""<XRHMD>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationVR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""VRLeftHand"",
            ""id"": ""ed544dae-979b-4568-95fd-b4162ea2922d"",
            ""actions"": [
                {
                    ""name"": ""RotationVR"",
                    ""type"": ""Value"",
                    ""id"": ""a32d3b5d-0a37-480a-989c-f3ff1059ca5e"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eb0cc8a4-e851-4a53-b791-42bd56a62564"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotationVR"",
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
                    ""name"": ""RotationVR"",
                    ""type"": ""Value"",
                    ""id"": ""75c41c1b-67ab-4c62-b2d6-687cb203ae6b"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""089f06ec-c363-4505-8df3-310b93d766a5"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""RotationVR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Locomotion"",
            ""id"": ""a6c172c9-5413-4acb-a77c-10a6ad471778"",
            ""actions"": [
                {
                    ""name"": ""SmoothMovement"",
                    ""type"": ""Value"",
                    ""id"": ""3c85606d-817a-49e6-9dd9-a12abe8eeaa7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""2a609968-9b74-427f-8a9f-6145b96b59d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9dc0dc74-52ac-409f-b003-cc837dfee4f4"",
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
                    ""id"": ""4761c9e6-154a-49ac-a804-d3df93a0cc32"",
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
                    ""id"": ""72823da1-1c9c-4ffa-9543-b03ce4bd67b0"",
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
                    ""id"": ""0f923144-849d-4911-8c6f-dd9501397a20"",
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
                    ""id"": ""45f37398-e124-4ccf-8cb3-a8bed6612bb7"",
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
                    ""id"": ""83cd1a8e-f534-4863-83d5-e963055f0ff4"",
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
                    ""id"": ""0c82f2aa-43ed-46fe-90aa-658a590c2702"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""SmoothMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa45ea63-88c6-49b3-ae25-322033d43aec"",
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
                    ""id"": ""4ce1d56f-63d1-48cd-b29d-9216b8a50e9d"",
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
                    ""id"": ""2f9962ee-3c5e-49a7-bf50-b60eb4b8ca94"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keys"",
            ""id"": ""6b7a7551-558f-44c2-b4da-0bdc827ba085"",
            ""actions"": [
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""ae1de367-56da-4e45-8ff6-649b94d31a43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""df56a750-1e1f-43df-9e13-86a3344c3573"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""99eccbc7-6a59-468c-bd88-bdb025ea64bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""7bb6dbe8-7106-4b44-94c1-fcf34f84444d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""21f51b4f-2644-489a-b327-6f746128a4d4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""5af32417-7c0f-41db-8e10-176fbd850b12"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6f12db2d-74d9-4bc1-9c3f-f177f5f91e2c"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14b9550f-b8d4-4726-9a21-0014a661287e"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f5ea2f8-08c5-4423-b01e-b3608b694d00"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""121287e4-8b8b-410c-8450-1f49a02ebfa8"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1efb3962-c7bf-4dbe-9e22-ce4d9ffa5ad1"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15230ca3-81ce-4d14-9668-056235026ec2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29e30acb-f4f7-4fda-ba0b-ae080a8cab05"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""849014ce-7bbc-4f1d-a78a-4bdb1c993efe"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""770a18bd-a89a-496e-9d1a-d3c7df00e808"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aacea737-7e15-4440-a152-9b4d68868e2f"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e68141e-a327-4c07-b9ac-fc7b79543ed5"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43f9c8e6-3b0b-4a71-bec1-412ca638b970"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b63bc6f-6950-473c-88e0-498d0792275a"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""RTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57e33bf9-b652-4971-a432-bdab0c5e020e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""RTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66cc1b78-c475-420d-a0c1-fca2186a55ab"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""RTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32c7d32c-93cf-49d2-a3f6-cfd3291f2684"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR Generic"",
                    ""action"": ""LTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""306052d8-3ee1-41a6-962f-4575b6ac16e1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC Generic"",
                    ""action"": ""LTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e95a5f0a-2e35-473e-8d27-1158c9c2eeda"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller Generic"",
                    ""action"": ""LTrigger"",
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
        // VRHead
        m_VRHead = asset.FindActionMap("VRHead", throwIfNotFound: true);
        m_VRHead_RotationVR = m_VRHead.FindAction("RotationVR", throwIfNotFound: true);
        // VRLeftHand
        m_VRLeftHand = asset.FindActionMap("VRLeftHand", throwIfNotFound: true);
        m_VRLeftHand_RotationVR = m_VRLeftHand.FindAction("RotationVR", throwIfNotFound: true);
        // VRRightHand
        m_VRRightHand = asset.FindActionMap("VRRightHand", throwIfNotFound: true);
        m_VRRightHand_RotationVR = m_VRRightHand.FindAction("RotationVR", throwIfNotFound: true);
        // Locomotion
        m_Locomotion = asset.FindActionMap("Locomotion", throwIfNotFound: true);
        m_Locomotion_SmoothMovement = m_Locomotion.FindAction("SmoothMovement", throwIfNotFound: true);
        m_Locomotion_Rotation = m_Locomotion.FindAction("Rotation", throwIfNotFound: true);
        // Keys
        m_Keys = asset.FindActionMap("Keys", throwIfNotFound: true);
        m_Keys_A = m_Keys.FindAction("A", throwIfNotFound: true);
        m_Keys_B = m_Keys.FindAction("B", throwIfNotFound: true);
        m_Keys_X = m_Keys.FindAction("X", throwIfNotFound: true);
        m_Keys_Y = m_Keys.FindAction("Y", throwIfNotFound: true);
        m_Keys_RTrigger = m_Keys.FindAction("RTrigger", throwIfNotFound: true);
        m_Keys_LTrigger = m_Keys.FindAction("LTrigger", throwIfNotFound: true);
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

    // VRHead
    private readonly InputActionMap m_VRHead;
    private IVRHeadActions m_VRHeadActionsCallbackInterface;
    private readonly InputAction m_VRHead_RotationVR;
    public struct VRHeadActions
    {
        private @VRAction m_Wrapper;
        public VRHeadActions(@VRAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotationVR => m_Wrapper.m_VRHead_RotationVR;
        public InputActionMap Get() { return m_Wrapper.m_VRHead; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VRHeadActions set) { return set.Get(); }
        public void SetCallbacks(IVRHeadActions instance)
        {
            if (m_Wrapper.m_VRHeadActionsCallbackInterface != null)
            {
                @RotationVR.started -= m_Wrapper.m_VRHeadActionsCallbackInterface.OnRotationVR;
                @RotationVR.performed -= m_Wrapper.m_VRHeadActionsCallbackInterface.OnRotationVR;
                @RotationVR.canceled -= m_Wrapper.m_VRHeadActionsCallbackInterface.OnRotationVR;
            }
            m_Wrapper.m_VRHeadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotationVR.started += instance.OnRotationVR;
                @RotationVR.performed += instance.OnRotationVR;
                @RotationVR.canceled += instance.OnRotationVR;
            }
        }
    }
    public VRHeadActions @VRHead => new VRHeadActions(this);

    // VRLeftHand
    private readonly InputActionMap m_VRLeftHand;
    private IVRLeftHandActions m_VRLeftHandActionsCallbackInterface;
    private readonly InputAction m_VRLeftHand_RotationVR;
    public struct VRLeftHandActions
    {
        private @VRAction m_Wrapper;
        public VRLeftHandActions(@VRAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotationVR => m_Wrapper.m_VRLeftHand_RotationVR;
        public InputActionMap Get() { return m_Wrapper.m_VRLeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VRLeftHandActions set) { return set.Get(); }
        public void SetCallbacks(IVRLeftHandActions instance)
        {
            if (m_Wrapper.m_VRLeftHandActionsCallbackInterface != null)
            {
                @RotationVR.started -= m_Wrapper.m_VRLeftHandActionsCallbackInterface.OnRotationVR;
                @RotationVR.performed -= m_Wrapper.m_VRLeftHandActionsCallbackInterface.OnRotationVR;
                @RotationVR.canceled -= m_Wrapper.m_VRLeftHandActionsCallbackInterface.OnRotationVR;
            }
            m_Wrapper.m_VRLeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotationVR.started += instance.OnRotationVR;
                @RotationVR.performed += instance.OnRotationVR;
                @RotationVR.canceled += instance.OnRotationVR;
            }
        }
    }
    public VRLeftHandActions @VRLeftHand => new VRLeftHandActions(this);

    // VRRightHand
    private readonly InputActionMap m_VRRightHand;
    private IVRRightHandActions m_VRRightHandActionsCallbackInterface;
    private readonly InputAction m_VRRightHand_RotationVR;
    public struct VRRightHandActions
    {
        private @VRAction m_Wrapper;
        public VRRightHandActions(@VRAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotationVR => m_Wrapper.m_VRRightHand_RotationVR;
        public InputActionMap Get() { return m_Wrapper.m_VRRightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VRRightHandActions set) { return set.Get(); }
        public void SetCallbacks(IVRRightHandActions instance)
        {
            if (m_Wrapper.m_VRRightHandActionsCallbackInterface != null)
            {
                @RotationVR.started -= m_Wrapper.m_VRRightHandActionsCallbackInterface.OnRotationVR;
                @RotationVR.performed -= m_Wrapper.m_VRRightHandActionsCallbackInterface.OnRotationVR;
                @RotationVR.canceled -= m_Wrapper.m_VRRightHandActionsCallbackInterface.OnRotationVR;
            }
            m_Wrapper.m_VRRightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotationVR.started += instance.OnRotationVR;
                @RotationVR.performed += instance.OnRotationVR;
                @RotationVR.canceled += instance.OnRotationVR;
            }
        }
    }
    public VRRightHandActions @VRRightHand => new VRRightHandActions(this);

    // Locomotion
    private readonly InputActionMap m_Locomotion;
    private ILocomotionActions m_LocomotionActionsCallbackInterface;
    private readonly InputAction m_Locomotion_SmoothMovement;
    private readonly InputAction m_Locomotion_Rotation;
    public struct LocomotionActions
    {
        private @VRAction m_Wrapper;
        public LocomotionActions(@VRAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @SmoothMovement => m_Wrapper.m_Locomotion_SmoothMovement;
        public InputAction @Rotation => m_Wrapper.m_Locomotion_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_Locomotion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocomotionActions set) { return set.Get(); }
        public void SetCallbacks(ILocomotionActions instance)
        {
            if (m_Wrapper.m_LocomotionActionsCallbackInterface != null)
            {
                @SmoothMovement.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSmoothMovement;
                @SmoothMovement.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSmoothMovement;
                @SmoothMovement.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnSmoothMovement;
                @Rotation.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_LocomotionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SmoothMovement.started += instance.OnSmoothMovement;
                @SmoothMovement.performed += instance.OnSmoothMovement;
                @SmoothMovement.canceled += instance.OnSmoothMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public LocomotionActions @Locomotion => new LocomotionActions(this);

    // Keys
    private readonly InputActionMap m_Keys;
    private IKeysActions m_KeysActionsCallbackInterface;
    private readonly InputAction m_Keys_A;
    private readonly InputAction m_Keys_B;
    private readonly InputAction m_Keys_X;
    private readonly InputAction m_Keys_Y;
    private readonly InputAction m_Keys_RTrigger;
    private readonly InputAction m_Keys_LTrigger;
    public struct KeysActions
    {
        private @VRAction m_Wrapper;
        public KeysActions(@VRAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @A => m_Wrapper.m_Keys_A;
        public InputAction @B => m_Wrapper.m_Keys_B;
        public InputAction @X => m_Wrapper.m_Keys_X;
        public InputAction @Y => m_Wrapper.m_Keys_Y;
        public InputAction @RTrigger => m_Wrapper.m_Keys_RTrigger;
        public InputAction @LTrigger => m_Wrapper.m_Keys_LTrigger;
        public InputActionMap Get() { return m_Wrapper.m_Keys; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeysActions set) { return set.Get(); }
        public void SetCallbacks(IKeysActions instance)
        {
            if (m_Wrapper.m_KeysActionsCallbackInterface != null)
            {
                @A.started -= m_Wrapper.m_KeysActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_KeysActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_KeysActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_KeysActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_KeysActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_KeysActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_KeysActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_KeysActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_KeysActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_KeysActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_KeysActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_KeysActionsCallbackInterface.OnY;
                @RTrigger.started -= m_Wrapper.m_KeysActionsCallbackInterface.OnRTrigger;
                @RTrigger.performed -= m_Wrapper.m_KeysActionsCallbackInterface.OnRTrigger;
                @RTrigger.canceled -= m_Wrapper.m_KeysActionsCallbackInterface.OnRTrigger;
                @LTrigger.started -= m_Wrapper.m_KeysActionsCallbackInterface.OnLTrigger;
                @LTrigger.performed -= m_Wrapper.m_KeysActionsCallbackInterface.OnLTrigger;
                @LTrigger.canceled -= m_Wrapper.m_KeysActionsCallbackInterface.OnLTrigger;
            }
            m_Wrapper.m_KeysActionsCallbackInterface = instance;
            if (instance != null)
            {
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @RTrigger.started += instance.OnRTrigger;
                @RTrigger.performed += instance.OnRTrigger;
                @RTrigger.canceled += instance.OnRTrigger;
                @LTrigger.started += instance.OnLTrigger;
                @LTrigger.performed += instance.OnLTrigger;
                @LTrigger.canceled += instance.OnLTrigger;
            }
        }
    }
    public KeysActions @Keys => new KeysActions(this);
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
    public interface IVRHeadActions
    {
        void OnRotationVR(InputAction.CallbackContext context);
    }
    public interface IVRLeftHandActions
    {
        void OnRotationVR(InputAction.CallbackContext context);
    }
    public interface IVRRightHandActions
    {
        void OnRotationVR(InputAction.CallbackContext context);
    }
    public interface ILocomotionActions
    {
        void OnSmoothMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface IKeysActions
    {
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnRTrigger(InputAction.CallbackContext context);
        void OnLTrigger(InputAction.CallbackContext context);
    }
}
