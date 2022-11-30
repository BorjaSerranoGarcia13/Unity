// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

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
            ""name"": ""Gameplay"",
            ""id"": ""4c305d5d-b178-45d3-a21c-86e329accc16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e76dc338-c6d4-456b-a380-0c4fe13be472"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Value"",
                    ""id"": ""6903e083-97ed-4843-87f8-3e3514e10704"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""ca45f515-0123-48da-bcbd-6827a6591552"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveMenu"",
                    ""type"": ""Button"",
                    ""id"": ""80cc5222-8484-4a7d-8fa3-984c7f641562"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRetry"",
                    ""type"": ""Button"",
                    ""id"": ""416b000e-7fda-412b-a55f-7ff555c5b208"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b5b17010-c592-4c32-888f-8c82ae276981"",
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
                    ""id"": ""91af127b-5eba-4490-9f70-d352e3a94b99"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1707d237-3610-41b9-9ca0-e63ad37f962f"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63dc4ef2-8e31-4a5b-a311-7615272364b5"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f2d0e92-67b0-4bfe-8576-8d6cf8e9d448"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc2958f1-f298-4ae3-9e88-205fc2aeee51"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRetry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_Move = m_Gameplay.GetAction("Move");
        m_Gameplay_Shoot = m_Gameplay.GetAction("Shoot");
        m_Gameplay_Press = m_Gameplay.GetAction("Press");
        m_Gameplay_MoveMenu = m_Gameplay.GetAction("MoveMenu");
        m_Gameplay_MoveRetry = m_Gameplay.GetAction("MoveRetry");
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_Press;
    private readonly InputAction m_Gameplay_MoveMenu;
    private readonly InputAction m_Gameplay_MoveRetry;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @Press => m_Wrapper.m_Gameplay_Press;
        public InputAction @MoveMenu => m_Wrapper.m_Gameplay_MoveMenu;
        public InputAction @MoveRetry => m_Wrapper.m_Gameplay_MoveRetry;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                Press.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPress;
                Press.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPress;
                Press.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPress;
                MoveMenu.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveMenu;
                MoveMenu.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveMenu;
                MoveMenu.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveMenu;
                MoveRetry.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRetry;
                MoveRetry.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRetry;
                MoveRetry.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRetry;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.canceled += instance.OnShoot;
                Press.started += instance.OnPress;
                Press.performed += instance.OnPress;
                Press.canceled += instance.OnPress;
                MoveMenu.started += instance.OnMoveMenu;
                MoveMenu.performed += instance.OnMoveMenu;
                MoveMenu.canceled += instance.OnMoveMenu;
                MoveRetry.started += instance.OnMoveRetry;
                MoveRetry.performed += instance.OnMoveRetry;
                MoveRetry.canceled += instance.OnMoveRetry;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPress(InputAction.CallbackContext context);
        void OnMoveMenu(InputAction.CallbackContext context);
        void OnMoveRetry(InputAction.CallbackContext context);
    }
}
