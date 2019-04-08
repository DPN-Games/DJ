// GENERATED AUTOMATICALLY FROM 'Assets/Input.inputactions'

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Input;


[Serializable]
public class InputActions : InputActionAssetReference
{
    public InputActions()
    {
    }
    public InputActions(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // Game
        m_Game = asset.GetActionMap("Game");
        m_Game_BlueTap = m_Game.GetAction("BlueTap");
        if (m_GameBlueTapActionStarted != null)
            m_Game_BlueTap.started += m_GameBlueTapActionStarted.Invoke;
        if (m_GameBlueTapActionPerformed != null)
            m_Game_BlueTap.performed += m_GameBlueTapActionPerformed.Invoke;
        if (m_GameBlueTapActionCancelled != null)
            m_Game_BlueTap.cancelled += m_GameBlueTapActionCancelled.Invoke;
        m_Game_RedTap = m_Game.GetAction("RedTap");
        if (m_GameRedTapActionStarted != null)
            m_Game_RedTap.started += m_GameRedTapActionStarted.Invoke;
        if (m_GameRedTapActionPerformed != null)
            m_Game_RedTap.performed += m_GameRedTapActionPerformed.Invoke;
        if (m_GameRedTapActionCancelled != null)
            m_Game_RedTap.cancelled += m_GameRedTapActionCancelled.Invoke;
        m_Game_GreenTap = m_Game.GetAction("GreenTap");
        if (m_GameGreenTapActionStarted != null)
            m_Game_GreenTap.started += m_GameGreenTapActionStarted.Invoke;
        if (m_GameGreenTapActionPerformed != null)
            m_Game_GreenTap.performed += m_GameGreenTapActionPerformed.Invoke;
        if (m_GameGreenTapActionCancelled != null)
            m_Game_GreenTap.cancelled += m_GameGreenTapActionCancelled.Invoke;
        m_Game_Fader = m_Game.GetAction("Fader");
        if (m_GameFaderActionStarted != null)
            m_Game_Fader.started += m_GameFaderActionStarted.Invoke;
        if (m_GameFaderActionPerformed != null)
            m_Game_Fader.performed += m_GameFaderActionPerformed.Invoke;
        if (m_GameFaderActionCancelled != null)
            m_Game_Fader.cancelled += m_GameFaderActionCancelled.Invoke;
        m_Game_Knob = m_Game.GetAction("Knob");
        if (m_GameKnobActionStarted != null)
            m_Game_Knob.started += m_GameKnobActionStarted.Invoke;
        if (m_GameKnobActionPerformed != null)
            m_Game_Knob.performed += m_GameKnobActionPerformed.Invoke;
        if (m_GameKnobActionCancelled != null)
            m_Game_Knob.cancelled += m_GameKnobActionCancelled.Invoke;
        m_Game_Euphoria = m_Game.GetAction("Euphoria");
        if (m_GameEuphoriaActionStarted != null)
            m_Game_Euphoria.started += m_GameEuphoriaActionStarted.Invoke;
        if (m_GameEuphoriaActionPerformed != null)
            m_Game_Euphoria.performed += m_GameEuphoriaActionPerformed.Invoke;
        if (m_GameEuphoriaActionCancelled != null)
            m_Game_Euphoria.cancelled += m_GameEuphoriaActionCancelled.Invoke;
        m_Game_Turntable = m_Game.GetAction("Turntable");
        if (m_GameTurntableActionStarted != null)
            m_Game_Turntable.started += m_GameTurntableActionStarted.Invoke;
        if (m_GameTurntableActionPerformed != null)
            m_Game_Turntable.performed += m_GameTurntableActionPerformed.Invoke;
        if (m_GameTurntableActionCancelled != null)
            m_Game_Turntable.cancelled += m_GameTurntableActionCancelled.Invoke;
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        if (m_GameActionsCallbackInterface != null)
        {
            Game.SetCallbacks(null);
        }
        m_Game = null;
        m_Game_BlueTap = null;
        if (m_GameBlueTapActionStarted != null)
            m_Game_BlueTap.started -= m_GameBlueTapActionStarted.Invoke;
        if (m_GameBlueTapActionPerformed != null)
            m_Game_BlueTap.performed -= m_GameBlueTapActionPerformed.Invoke;
        if (m_GameBlueTapActionCancelled != null)
            m_Game_BlueTap.cancelled -= m_GameBlueTapActionCancelled.Invoke;
        m_Game_RedTap = null;
        if (m_GameRedTapActionStarted != null)
            m_Game_RedTap.started -= m_GameRedTapActionStarted.Invoke;
        if (m_GameRedTapActionPerformed != null)
            m_Game_RedTap.performed -= m_GameRedTapActionPerformed.Invoke;
        if (m_GameRedTapActionCancelled != null)
            m_Game_RedTap.cancelled -= m_GameRedTapActionCancelled.Invoke;
        m_Game_GreenTap = null;
        if (m_GameGreenTapActionStarted != null)
            m_Game_GreenTap.started -= m_GameGreenTapActionStarted.Invoke;
        if (m_GameGreenTapActionPerformed != null)
            m_Game_GreenTap.performed -= m_GameGreenTapActionPerformed.Invoke;
        if (m_GameGreenTapActionCancelled != null)
            m_Game_GreenTap.cancelled -= m_GameGreenTapActionCancelled.Invoke;
        m_Game_Fader = null;
        if (m_GameFaderActionStarted != null)
            m_Game_Fader.started -= m_GameFaderActionStarted.Invoke;
        if (m_GameFaderActionPerformed != null)
            m_Game_Fader.performed -= m_GameFaderActionPerformed.Invoke;
        if (m_GameFaderActionCancelled != null)
            m_Game_Fader.cancelled -= m_GameFaderActionCancelled.Invoke;
        m_Game_Knob = null;
        if (m_GameKnobActionStarted != null)
            m_Game_Knob.started -= m_GameKnobActionStarted.Invoke;
        if (m_GameKnobActionPerformed != null)
            m_Game_Knob.performed -= m_GameKnobActionPerformed.Invoke;
        if (m_GameKnobActionCancelled != null)
            m_Game_Knob.cancelled -= m_GameKnobActionCancelled.Invoke;
        m_Game_Euphoria = null;
        if (m_GameEuphoriaActionStarted != null)
            m_Game_Euphoria.started -= m_GameEuphoriaActionStarted.Invoke;
        if (m_GameEuphoriaActionPerformed != null)
            m_Game_Euphoria.performed -= m_GameEuphoriaActionPerformed.Invoke;
        if (m_GameEuphoriaActionCancelled != null)
            m_Game_Euphoria.cancelled -= m_GameEuphoriaActionCancelled.Invoke;
        m_Game_Turntable = null;
        if (m_GameTurntableActionStarted != null)
            m_Game_Turntable.started -= m_GameTurntableActionStarted.Invoke;
        if (m_GameTurntableActionPerformed != null)
            m_Game_Turntable.performed -= m_GameTurntableActionPerformed.Invoke;
        if (m_GameTurntableActionCancelled != null)
            m_Game_Turntable.cancelled -= m_GameTurntableActionCancelled.Invoke;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        var GameCallbacks = m_GameActionsCallbackInterface;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
        Game.SetCallbacks(GameCallbacks);
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // Game
    private InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private InputAction m_Game_BlueTap;
    [SerializeField] private ActionEvent m_GameBlueTapActionStarted;
    [SerializeField] private ActionEvent m_GameBlueTapActionPerformed;
    [SerializeField] private ActionEvent m_GameBlueTapActionCancelled;
    private InputAction m_Game_RedTap;
    [SerializeField] private ActionEvent m_GameRedTapActionStarted;
    [SerializeField] private ActionEvent m_GameRedTapActionPerformed;
    [SerializeField] private ActionEvent m_GameRedTapActionCancelled;
    private InputAction m_Game_GreenTap;
    [SerializeField] private ActionEvent m_GameGreenTapActionStarted;
    [SerializeField] private ActionEvent m_GameGreenTapActionPerformed;
    [SerializeField] private ActionEvent m_GameGreenTapActionCancelled;
    private InputAction m_Game_Fader;
    [SerializeField] private ActionEvent m_GameFaderActionStarted;
    [SerializeField] private ActionEvent m_GameFaderActionPerformed;
    [SerializeField] private ActionEvent m_GameFaderActionCancelled;
    private InputAction m_Game_Knob;
    [SerializeField] private ActionEvent m_GameKnobActionStarted;
    [SerializeField] private ActionEvent m_GameKnobActionPerformed;
    [SerializeField] private ActionEvent m_GameKnobActionCancelled;
    private InputAction m_Game_Euphoria;
    [SerializeField] private ActionEvent m_GameEuphoriaActionStarted;
    [SerializeField] private ActionEvent m_GameEuphoriaActionPerformed;
    [SerializeField] private ActionEvent m_GameEuphoriaActionCancelled;
    private InputAction m_Game_Turntable;
    [SerializeField] private ActionEvent m_GameTurntableActionStarted;
    [SerializeField] private ActionEvent m_GameTurntableActionPerformed;
    [SerializeField] private ActionEvent m_GameTurntableActionCancelled;
    public struct GameActions
    {
        private InputActions m_Wrapper;
        public GameActions(InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @BlueTap { get { return m_Wrapper.m_Game_BlueTap; } }
        public ActionEvent BlueTapStarted { get { return m_Wrapper.m_GameBlueTapActionStarted; } }
        public ActionEvent BlueTapPerformed { get { return m_Wrapper.m_GameBlueTapActionPerformed; } }
        public ActionEvent BlueTapCancelled { get { return m_Wrapper.m_GameBlueTapActionCancelled; } }
        public InputAction @RedTap { get { return m_Wrapper.m_Game_RedTap; } }
        public ActionEvent RedTapStarted { get { return m_Wrapper.m_GameRedTapActionStarted; } }
        public ActionEvent RedTapPerformed { get { return m_Wrapper.m_GameRedTapActionPerformed; } }
        public ActionEvent RedTapCancelled { get { return m_Wrapper.m_GameRedTapActionCancelled; } }
        public InputAction @GreenTap { get { return m_Wrapper.m_Game_GreenTap; } }
        public ActionEvent GreenTapStarted { get { return m_Wrapper.m_GameGreenTapActionStarted; } }
        public ActionEvent GreenTapPerformed { get { return m_Wrapper.m_GameGreenTapActionPerformed; } }
        public ActionEvent GreenTapCancelled { get { return m_Wrapper.m_GameGreenTapActionCancelled; } }
        public InputAction @Fader { get { return m_Wrapper.m_Game_Fader; } }
        public ActionEvent FaderStarted { get { return m_Wrapper.m_GameFaderActionStarted; } }
        public ActionEvent FaderPerformed { get { return m_Wrapper.m_GameFaderActionPerformed; } }
        public ActionEvent FaderCancelled { get { return m_Wrapper.m_GameFaderActionCancelled; } }
        public InputAction @Knob { get { return m_Wrapper.m_Game_Knob; } }
        public ActionEvent KnobStarted { get { return m_Wrapper.m_GameKnobActionStarted; } }
        public ActionEvent KnobPerformed { get { return m_Wrapper.m_GameKnobActionPerformed; } }
        public ActionEvent KnobCancelled { get { return m_Wrapper.m_GameKnobActionCancelled; } }
        public InputAction @Euphoria { get { return m_Wrapper.m_Game_Euphoria; } }
        public ActionEvent EuphoriaStarted { get { return m_Wrapper.m_GameEuphoriaActionStarted; } }
        public ActionEvent EuphoriaPerformed { get { return m_Wrapper.m_GameEuphoriaActionPerformed; } }
        public ActionEvent EuphoriaCancelled { get { return m_Wrapper.m_GameEuphoriaActionCancelled; } }
        public InputAction @Turntable { get { return m_Wrapper.m_Game_Turntable; } }
        public ActionEvent TurntableStarted { get { return m_Wrapper.m_GameTurntableActionStarted; } }
        public ActionEvent TurntablePerformed { get { return m_Wrapper.m_GameTurntableActionPerformed; } }
        public ActionEvent TurntableCancelled { get { return m_Wrapper.m_GameTurntableActionCancelled; } }
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                BlueTap.started -= m_Wrapper.m_GameActionsCallbackInterface.OnBlueTap;
                BlueTap.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnBlueTap;
                BlueTap.cancelled -= m_Wrapper.m_GameActionsCallbackInterface.OnBlueTap;
                RedTap.started -= m_Wrapper.m_GameActionsCallbackInterface.OnRedTap;
                RedTap.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnRedTap;
                RedTap.cancelled -= m_Wrapper.m_GameActionsCallbackInterface.OnRedTap;
                GreenTap.started -= m_Wrapper.m_GameActionsCallbackInterface.OnGreenTap;
                GreenTap.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnGreenTap;
                GreenTap.cancelled -= m_Wrapper.m_GameActionsCallbackInterface.OnGreenTap;
                Fader.started -= m_Wrapper.m_GameActionsCallbackInterface.OnFader;
                Fader.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnFader;
                Fader.cancelled -= m_Wrapper.m_GameActionsCallbackInterface.OnFader;
                Knob.started -= m_Wrapper.m_GameActionsCallbackInterface.OnKnob;
                Knob.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnKnob;
                Knob.cancelled -= m_Wrapper.m_GameActionsCallbackInterface.OnKnob;
                Euphoria.started -= m_Wrapper.m_GameActionsCallbackInterface.OnEuphoria;
                Euphoria.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnEuphoria;
                Euphoria.cancelled -= m_Wrapper.m_GameActionsCallbackInterface.OnEuphoria;
                Turntable.started -= m_Wrapper.m_GameActionsCallbackInterface.OnTurntable;
                Turntable.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnTurntable;
                Turntable.cancelled -= m_Wrapper.m_GameActionsCallbackInterface.OnTurntable;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                BlueTap.started += instance.OnBlueTap;
                BlueTap.performed += instance.OnBlueTap;
                BlueTap.cancelled += instance.OnBlueTap;
                RedTap.started += instance.OnRedTap;
                RedTap.performed += instance.OnRedTap;
                RedTap.cancelled += instance.OnRedTap;
                GreenTap.started += instance.OnGreenTap;
                GreenTap.performed += instance.OnGreenTap;
                GreenTap.cancelled += instance.OnGreenTap;
                Fader.started += instance.OnFader;
                Fader.performed += instance.OnFader;
                Fader.cancelled += instance.OnFader;
                Knob.started += instance.OnKnob;
                Knob.performed += instance.OnKnob;
                Knob.cancelled += instance.OnKnob;
                Euphoria.started += instance.OnEuphoria;
                Euphoria.performed += instance.OnEuphoria;
                Euphoria.cancelled += instance.OnEuphoria;
                Turntable.started += instance.OnTurntable;
                Turntable.performed += instance.OnTurntable;
                Turntable.cancelled += instance.OnTurntable;
            }
        }
    }
    public GameActions @Game
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new GameActions(this);
        }
    }
    [Serializable]
    public class ActionEvent : UnityEvent<InputAction.CallbackContext>
    {
    }
}
public interface IGameActions
{
    void OnBlueTap(InputAction.CallbackContext context);
    void OnRedTap(InputAction.CallbackContext context);
    void OnGreenTap(InputAction.CallbackContext context);
    void OnFader(InputAction.CallbackContext context);
    void OnKnob(InputAction.CallbackContext context);
    void OnEuphoria(InputAction.CallbackContext context);
    void OnTurntable(InputAction.CallbackContext context);
}
