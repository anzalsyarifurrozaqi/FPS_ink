// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Character Control/Input Device/MainInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ad8bc0f0-fa00-4c33-b993-a381a5160cb9"",
            ""actions"": [
                {
                    ""name"": ""MOVE"",
                    ""type"": ""Value"",
                    ""id"": ""e8c5e2a8-771f-4d5e-bda4-70e7b2503b56"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LOOK"",
                    ""type"": ""Value"",
                    ""id"": ""a03019be-5711-4f0e-9236-bddba6492c07"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ATTACK"",
                    ""type"": ""Button"",
                    ""id"": ""3bf71b90-6e58-450b-b195-422347add6b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AIM"",
                    ""type"": ""Button"",
                    ""id"": ""cb07fe95-b3ea-4625-8a0d-bf357c5d0963"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""eccef211-58bf-404a-a1a0-c8fbd2dded6d"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c9025c3f-7c0f-4abd-a098-a207bc21f6a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eccfef9e-5415-418f-9f5b-c4144d4984b4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d85a41b2-b6db-481f-9462-3ce74082a18a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""655ab995-09db-42cb-be81-a6a2f823d6be"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6363ee2e-874e-4996-a0d0-d67f3a3f2193"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ATTACK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c632ec0-44db-413c-8771-7e2b2b05fd23"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AIM"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""049e16e7-867e-458f-a630-e040369f8ddb"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false),ScaleVector2(x=15,y=15)"",
                    ""groups"": """",
                    ""action"": ""LOOK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MOVE = m_Player.FindAction("MOVE", throwIfNotFound: true);
        m_Player_LOOK = m_Player.FindAction("LOOK", throwIfNotFound: true);
        m_Player_ATTACK = m_Player.FindAction("ATTACK", throwIfNotFound: true);
        m_Player_AIM = m_Player.FindAction("AIM", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MOVE;
    private readonly InputAction m_Player_LOOK;
    private readonly InputAction m_Player_ATTACK;
    private readonly InputAction m_Player_AIM;
    public struct PlayerActions
    {
        private @MainInput m_Wrapper;
        public PlayerActions(@MainInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MOVE => m_Wrapper.m_Player_MOVE;
        public InputAction @LOOK => m_Wrapper.m_Player_LOOK;
        public InputAction @ATTACK => m_Wrapper.m_Player_ATTACK;
        public InputAction @AIM => m_Wrapper.m_Player_AIM;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MOVE.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMOVE;
                @MOVE.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMOVE;
                @MOVE.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMOVE;
                @LOOK.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLOOK;
                @LOOK.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLOOK;
                @LOOK.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLOOK;
                @ATTACK.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnATTACK;
                @ATTACK.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnATTACK;
                @ATTACK.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnATTACK;
                @AIM.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAIM;
                @AIM.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAIM;
                @AIM.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAIM;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MOVE.started += instance.OnMOVE;
                @MOVE.performed += instance.OnMOVE;
                @MOVE.canceled += instance.OnMOVE;
                @LOOK.started += instance.OnLOOK;
                @LOOK.performed += instance.OnLOOK;
                @LOOK.canceled += instance.OnLOOK;
                @ATTACK.started += instance.OnATTACK;
                @ATTACK.performed += instance.OnATTACK;
                @ATTACK.canceled += instance.OnATTACK;
                @AIM.started += instance.OnAIM;
                @AIM.performed += instance.OnAIM;
                @AIM.canceled += instance.OnAIM;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMOVE(InputAction.CallbackContext context);
        void OnLOOK(InputAction.CallbackContext context);
        void OnATTACK(InputAction.CallbackContext context);
        void OnAIM(InputAction.CallbackContext context);
    }
}
