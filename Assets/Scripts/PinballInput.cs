//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PinballInput.inputactions
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

public partial class @PinballInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PinballInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PinballInput"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""fcdec1bc-60c9-4ecb-a3d6-149508e24d7c"",
            ""actions"": [
                {
                    ""name"": ""Launch"",
                    ""type"": ""Value"",
                    ""id"": ""072aac51-726a-4152-a2bd-e33feb5cf620"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FlipperLeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""0d6081ff-68b4-4696-b500-fef511065af0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipperRightClick"",
                    ""type"": ""Button"",
                    ""id"": ""1fd70de3-7b6d-4718-be7f-779400ef6057"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5cb24366-5745-4759-bc42-7972e6a3a4c3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Launch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""910efadd-c894-4977-ac81-870a3c65fa39"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Launch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c36ebf62-3fcd-4c60-ac02-cf8e233c3c9c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperLeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7afb0c6-0f9c-4da1-91af-6522b95271e9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperLeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""741f1cdb-bf67-4c25-8839-08cb75ee1733"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperRightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d55f7879-9a34-4a49-b8bf-0432ef4e2caf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperRightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Launch = m_Default.FindAction("Launch", throwIfNotFound: true);
        m_Default_FlipperLeftClick = m_Default.FindAction("FlipperLeftClick", throwIfNotFound: true);
        m_Default_FlipperRightClick = m_Default.FindAction("FlipperRightClick", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private List<IDefaultActions> m_DefaultActionsCallbackInterfaces = new List<IDefaultActions>();
    private readonly InputAction m_Default_Launch;
    private readonly InputAction m_Default_FlipperLeftClick;
    private readonly InputAction m_Default_FlipperRightClick;
    public struct DefaultActions
    {
        private @PinballInput m_Wrapper;
        public DefaultActions(@PinballInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Launch => m_Wrapper.m_Default_Launch;
        public InputAction @FlipperLeftClick => m_Wrapper.m_Default_FlipperLeftClick;
        public InputAction @FlipperRightClick => m_Wrapper.m_Default_FlipperRightClick;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Add(instance);
            @Launch.started += instance.OnLaunch;
            @Launch.performed += instance.OnLaunch;
            @Launch.canceled += instance.OnLaunch;
            @FlipperLeftClick.started += instance.OnFlipperLeftClick;
            @FlipperLeftClick.performed += instance.OnFlipperLeftClick;
            @FlipperLeftClick.canceled += instance.OnFlipperLeftClick;
            @FlipperRightClick.started += instance.OnFlipperRightClick;
            @FlipperRightClick.performed += instance.OnFlipperRightClick;
            @FlipperRightClick.canceled += instance.OnFlipperRightClick;
        }

        private void UnregisterCallbacks(IDefaultActions instance)
        {
            @Launch.started -= instance.OnLaunch;
            @Launch.performed -= instance.OnLaunch;
            @Launch.canceled -= instance.OnLaunch;
            @FlipperLeftClick.started -= instance.OnFlipperLeftClick;
            @FlipperLeftClick.performed -= instance.OnFlipperLeftClick;
            @FlipperLeftClick.canceled -= instance.OnFlipperLeftClick;
            @FlipperRightClick.started -= instance.OnFlipperRightClick;
            @FlipperRightClick.performed -= instance.OnFlipperRightClick;
            @FlipperRightClick.canceled -= instance.OnFlipperRightClick;
        }

        public void RemoveCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnLaunch(InputAction.CallbackContext context);
        void OnFlipperLeftClick(InputAction.CallbackContext context);
        void OnFlipperRightClick(InputAction.CallbackContext context);
    }
}