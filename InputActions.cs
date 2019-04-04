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
        m_Game_Blue = m_Game.GetAction("Blue");
        if (m_GameBlueActionStarted != null)
            m_Game_Blue.started += m_GameBlueActionStarted.Invoke;
        if (m_GameBlueActionPerformed != null)
            m_Game_Blue.performed += m_GameBlueActionPerformed.Invoke;
        if (m_GameBlueActionCancelled != null)
            m_Game_Blue.cancelled += m_GameBlueActionCancelled.Invoke;
        m_Game_Red = m_Game.GetAction("Red");
        if (m_GameRedActionStarted != null)
            m_Game_Red.started += m_GameRedActionStarted.Invoke;
        if (m_GameRedActionPerformed != null)
            m_Game_Red.performed += m_GameRedActionPerformed.Invoke;
        if (m_GameRedActionCancelled != null)
            m_Game_Red.cancelled += m_GameRedActionCancelled.Invoke;
        m_Game_Green = m_Game.GetAction("Green");
        if (m_GameGreenActionStarted != null)
            m_Game_Green.started += m_GameGreenActionStarted.Invoke;
        if (m_GameGreenActionPerformed != null)
            m_Game_Green.performed += m_GameGreenActionPerformed.Invoke;
        if (m_GameGreenActionCancelled != null)
            m_Game_Green.cancelled += m_GameGreenActionCancelled.Invoke;
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
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Game = null;
        m_Game_Blue = null;
        if (m_GameBlueActionStarted != null)
            m_Game_Blue.started -= m_GameBlueActionStarted.Invoke;
        if (m_GameBlueActionPerformed != null)
            m_Game_Blue.performed -= m_GameBlueActionPerformed.Invoke;
        if (m_GameBlueActionCancelled != null)
            m_Game_Blue.cancelled -= m_GameBlueActionCancelled.Invoke;
        m_Game_Red = null;
        if (m_GameRedActionStarted != null)
            m_Game_Red.started -= m_GameRedActionStarted.Invoke;
        if (m_GameRedActionPerformed != null)
            m_Game_Red.performed -= m_GameRedActionPerformed.Invoke;
        if (m_GameRedActionCancelled != null)
            m_Game_Red.cancelled -= m_GameRedActionCancelled.Invoke;
        m_Game_Green = null;
        if (m_GameGreenActionStarted != null)
            m_Game_Green.started -= m_GameGreenActionStarted.Invoke;
        if (m_GameGreenActionPerformed != null)
            m_Game_Green.performed -= m_GameGreenActionPerformed.Invoke;
        if (m_GameGreenActionCancelled != null)
            m_Game_Green.cancelled -= m_GameGreenActionCancelled.Invoke;
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
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // Game
    private InputActionMap m_Game;
    private InputAction m_Game_Blue;
    [SerializeField] private ActionEvent m_GameBlueActionStarted;
    [SerializeField] private ActionEvent m_GameBlueActionPerformed;
    [SerializeField] private ActionEvent m_GameBlueActionCancelled;
    private InputAction m_Game_Red;
    [SerializeField] private ActionEvent m_GameRedActionStarted;
    [SerializeField] private ActionEvent m_GameRedActionPerformed;
    [SerializeField] private ActionEvent m_GameRedActionCancelled;
    private InputAction m_Game_Green;
    [SerializeField] private ActionEvent m_GameGreenActionStarted;
    [SerializeField] private ActionEvent m_GameGreenActionPerformed;
    [SerializeField] private ActionEvent m_GameGreenActionCancelled;
    private InputAction m_Game_Fader;
    [SerializeField] private ActionEvent m_GameFaderActionStarted;
    [SerializeField] private ActionEvent m_GameFaderActionPerformed;
    [SerializeField] private ActionEvent m_GameFaderActionCancelled;
    private InputAction m_Game_Knob;
    [SerializeField] private ActionEvent m_GameKnobActionStarted;
    [SerializeField] private ActionEvent m_GameKnobActionPerformed;
    [SerializeField] private ActionEvent m_GameKnobActionCancelled;
    public struct GameActions
    {
        private InputActions m_Wrapper;
        public GameActions(InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Blue { get { return m_Wrapper.m_Game_Blue; } }
        public ActionEvent BlueStarted { get { return m_Wrapper.m_GameBlueActionStarted; } }
        public ActionEvent BluePerformed { get { return m_Wrapper.m_GameBlueActionPerformed; } }
        public ActionEvent BlueCancelled { get { return m_Wrapper.m_GameBlueActionCancelled; } }
        public InputAction @Red { get { return m_Wrapper.m_Game_Red; } }
        public ActionEvent RedStarted { get { return m_Wrapper.m_GameRedActionStarted; } }
        public ActionEvent RedPerformed { get { return m_Wrapper.m_GameRedActionPerformed; } }
        public ActionEvent RedCancelled { get { return m_Wrapper.m_GameRedActionCancelled; } }
        public InputAction @Green { get { return m_Wrapper.m_Game_Green; } }
        public ActionEvent GreenStarted { get { return m_Wrapper.m_GameGreenActionStarted; } }
        public ActionEvent GreenPerformed { get { return m_Wrapper.m_GameGreenActionPerformed; } }
        public ActionEvent GreenCancelled { get { return m_Wrapper.m_GameGreenActionCancelled; } }
        public InputAction @Fader { get { return m_Wrapper.m_Game_Fader; } }
        public ActionEvent FaderStarted { get { return m_Wrapper.m_GameFaderActionStarted; } }
        public ActionEvent FaderPerformed { get { return m_Wrapper.m_GameFaderActionPerformed; } }
        public ActionEvent FaderCancelled { get { return m_Wrapper.m_GameFaderActionCancelled; } }
        public InputAction @Knob { get { return m_Wrapper.m_Game_Knob; } }
        public ActionEvent KnobStarted { get { return m_Wrapper.m_GameKnobActionStarted; } }
        public ActionEvent KnobPerformed { get { return m_Wrapper.m_GameKnobActionPerformed; } }
        public ActionEvent KnobCancelled { get { return m_Wrapper.m_GameKnobActionCancelled; } }
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
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
