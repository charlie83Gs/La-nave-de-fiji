// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""d6e15f4a-5cab-46a8-8914-a5965331eaae"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""76b4554a-775a-47f8-8091-c9bf74c23f13"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp/Throw"",
                    ""type"": ""Button"",
                    ""id"": ""3658fe5d-ec0f-4f27-a658-e9f6252a813f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""324b715d-23b1-458b-9ad6-a0d0befe4252"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bdcbe211-63b2-48b3-9fb7-bcdc8bccc645"",
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
                    ""id"": ""2c62bffe-22ca-4b5f-86d7-3b05667a3ec2"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78e3e006-9173-4e8a-8cec-5f8fa9601fef"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp/Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3546e58e-2b6c-4c8b-ab4b-58f9ac55462d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerTwo"",
            ""id"": ""0ff79e00-282e-4546-ae87-8199d0984a89"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""f7e68a9f-0a1e-4bf0-a647-343311dded47"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp/Throw"",
                    ""type"": ""Button"",
                    ""id"": ""618d239c-6d3b-4190-92ee-3b92360120ce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""d2f625e8-5f7e-4232-970b-3361318ebd71"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b22ae7e0-4ea5-4c50-8658-ed094af72ff5"",
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
                    ""id"": ""1f689dab-665c-44b3-8f2e-f2903c0b1afd"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b159a5a-696e-4c16-9d63-4188d6dac94e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp/Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84ca785f-eebc-486f-9f19-1290bff31397"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerThree"",
            ""id"": ""d20f70ea-1944-457f-a21a-ecec8701300d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""ab2b427e-6e36-44ec-bd53-e0e4046d7e78"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp/Throw"",
                    ""type"": ""Button"",
                    ""id"": ""f5328e74-a5bd-445c-ba34-e8b78907004b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""0b165be2-1077-4d22-b757-b9fba7165367"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b72f5c76-ca72-4d8a-bdc3-82d4820020f5"",
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
                    ""id"": ""13bdc9cb-4d0b-4db1-bdff-2e8876f1e762"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12f56e10-7aff-48c0-a9a7-09708ea24f18"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp/Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cd7ce52-629f-4b84-902d-60e43a064f91"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerFour"",
            ""id"": ""6231b707-2d28-4173-9e6d-470e68bee06c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""18dc6140-f487-4f92-86e6-54c8566cc2e8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp/Throw"",
                    ""type"": ""Button"",
                    ""id"": ""707aa3c0-ef25-478a-a96f-0043ff46ce09"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""8ff8fa74-69a9-439a-aee4-246220fe6660"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2f964387-c1d4-47f6-81de-c059af1493fe"",
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
                    ""id"": ""2243a229-b6d8-4f11-a681-35a5269f994e"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c6005c9-051e-44d4-8adc-f0307b8e809d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp/Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74e06383-c868-4242-84e8-f43060ef3a0f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerOne
        m_PlayerOne = asset.GetActionMap("PlayerOne");
        m_PlayerOne_Move = m_PlayerOne.GetAction("Move");
        m_PlayerOne_PickUpThrow = m_PlayerOne.GetAction("PickUp/Throw");
        m_PlayerOne_Aim = m_PlayerOne.GetAction("Aim");
        // PlayerTwo
        m_PlayerTwo = asset.GetActionMap("PlayerTwo");
        m_PlayerTwo_Aim = m_PlayerTwo.GetAction("Aim");
        m_PlayerTwo_PickUpThrow = m_PlayerTwo.GetAction("PickUp/Throw");
        m_PlayerTwo_Move = m_PlayerTwo.GetAction("Move");
        // PlayerThree
        m_PlayerThree = asset.GetActionMap("PlayerThree");
        m_PlayerThree_Move = m_PlayerThree.GetAction("Move");
        m_PlayerThree_PickUpThrow = m_PlayerThree.GetAction("PickUp/Throw");
        m_PlayerThree_Aim = m_PlayerThree.GetAction("Aim");
        // PlayerFour
        m_PlayerFour = asset.GetActionMap("PlayerFour");
        m_PlayerFour_Move = m_PlayerFour.GetAction("Move");
        m_PlayerFour_PickUpThrow = m_PlayerFour.GetAction("PickUp/Throw");
        m_PlayerFour_Aim = m_PlayerFour.GetAction("Aim");
    }

    ~PlayerControls()
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

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_Move;
    private readonly InputAction m_PlayerOne_PickUpThrow;
    private readonly InputAction m_PlayerOne_Aim;
    public struct PlayerOneActions
    {
        private PlayerControls m_Wrapper;
        public PlayerOneActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerOne_Move;
        public InputAction @PickUpThrow => m_Wrapper.m_PlayerOne_PickUpThrow;
        public InputAction @Aim => m_Wrapper.m_PlayerOne_Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                PickUpThrow.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPickUpThrow;
                Aim.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnAim;
                Aim.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnAim;
                Aim.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                PickUpThrow.started += instance.OnPickUpThrow;
                PickUpThrow.performed += instance.OnPickUpThrow;
                PickUpThrow.canceled += instance.OnPickUpThrow;
                Aim.started += instance.OnAim;
                Aim.performed += instance.OnAim;
                Aim.canceled += instance.OnAim;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private IPlayerTwoActions m_PlayerTwoActionsCallbackInterface;
    private readonly InputAction m_PlayerTwo_Aim;
    private readonly InputAction m_PlayerTwo_PickUpThrow;
    private readonly InputAction m_PlayerTwo_Move;
    public struct PlayerTwoActions
    {
        private PlayerControls m_Wrapper;
        public PlayerTwoActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_PlayerTwo_Aim;
        public InputAction @PickUpThrow => m_Wrapper.m_PlayerTwo_PickUpThrow;
        public InputAction @Move => m_Wrapper.m_PlayerTwo_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTwoActions instance)
        {
            if (m_Wrapper.m_PlayerTwoActionsCallbackInterface != null)
            {
                Aim.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnAim;
                Aim.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnAim;
                Aim.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnAim;
                PickUpThrow.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPickUpThrow;
                Move.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerTwoActionsCallbackInterface = instance;
            if (instance != null)
            {
                Aim.started += instance.OnAim;
                Aim.performed += instance.OnAim;
                Aim.canceled += instance.OnAim;
                PickUpThrow.started += instance.OnPickUpThrow;
                PickUpThrow.performed += instance.OnPickUpThrow;
                PickUpThrow.canceled += instance.OnPickUpThrow;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);

    // PlayerThree
    private readonly InputActionMap m_PlayerThree;
    private IPlayerThreeActions m_PlayerThreeActionsCallbackInterface;
    private readonly InputAction m_PlayerThree_Move;
    private readonly InputAction m_PlayerThree_PickUpThrow;
    private readonly InputAction m_PlayerThree_Aim;
    public struct PlayerThreeActions
    {
        private PlayerControls m_Wrapper;
        public PlayerThreeActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerThree_Move;
        public InputAction @PickUpThrow => m_Wrapper.m_PlayerThree_PickUpThrow;
        public InputAction @Aim => m_Wrapper.m_PlayerThree_Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerThree; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerThreeActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerThreeActions instance)
        {
            if (m_Wrapper.m_PlayerThreeActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnMove;
                PickUpThrow.started -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.performed -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.canceled -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnPickUpThrow;
                Aim.started -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnAim;
                Aim.performed -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnAim;
                Aim.canceled -= m_Wrapper.m_PlayerThreeActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_PlayerThreeActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                PickUpThrow.started += instance.OnPickUpThrow;
                PickUpThrow.performed += instance.OnPickUpThrow;
                PickUpThrow.canceled += instance.OnPickUpThrow;
                Aim.started += instance.OnAim;
                Aim.performed += instance.OnAim;
                Aim.canceled += instance.OnAim;
            }
        }
    }
    public PlayerThreeActions @PlayerThree => new PlayerThreeActions(this);

    // PlayerFour
    private readonly InputActionMap m_PlayerFour;
    private IPlayerFourActions m_PlayerFourActionsCallbackInterface;
    private readonly InputAction m_PlayerFour_Move;
    private readonly InputAction m_PlayerFour_PickUpThrow;
    private readonly InputAction m_PlayerFour_Aim;
    public struct PlayerFourActions
    {
        private PlayerControls m_Wrapper;
        public PlayerFourActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerFour_Move;
        public InputAction @PickUpThrow => m_Wrapper.m_PlayerFour_PickUpThrow;
        public InputAction @Aim => m_Wrapper.m_PlayerFour_Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerFour; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerFourActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerFourActions instance)
        {
            if (m_Wrapper.m_PlayerFourActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnMove;
                PickUpThrow.started -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.performed -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnPickUpThrow;
                PickUpThrow.canceled -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnPickUpThrow;
                Aim.started -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnAim;
                Aim.performed -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnAim;
                Aim.canceled -= m_Wrapper.m_PlayerFourActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_PlayerFourActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                PickUpThrow.started += instance.OnPickUpThrow;
                PickUpThrow.performed += instance.OnPickUpThrow;
                PickUpThrow.canceled += instance.OnPickUpThrow;
                Aim.started += instance.OnAim;
                Aim.performed += instance.OnAim;
                Aim.canceled += instance.OnAim;
            }
        }
    }
    public PlayerFourActions @PlayerFour => new PlayerFourActions(this);
    public interface IPlayerOneActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPickUpThrow(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
    public interface IPlayerTwoActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnPickUpThrow(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayerThreeActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPickUpThrow(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
    public interface IPlayerFourActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPickUpThrow(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
