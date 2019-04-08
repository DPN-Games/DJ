using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.UI;

public class ControllerDebug : MonoBehaviour, IGameActions
{
    [SerializeField]
    InputActions inputActions;

    public Image red;
    public Image green;
    public Image blue;

    public Image fader;
    public Image knob;

    public Image euphoria;

    public Image upArrow;
    public Image downArrow;

    [Range(0, .01f)]
    public float threshold;

    private void Awake () {
        inputActions.Game.SetCallbacks(this);
    }

    private void OnEnable () {
        try {
            inputActions.Game.Enable();
        } catch (Exception e) {

        }
    }

    private void OnDisable () {
        try {
            inputActions.Game.Disable();
        } catch (Exception e) {

        }
    }

    public void OnBlueTap (InputAction.CallbackContext context) {
        if (context.started) {
            blue.rectTransform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        } else if (context.cancelled || context.performed) {
            blue.rectTransform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void OnRedTap (InputAction.CallbackContext context) {
        if (context.started) {
            red.rectTransform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        } else if (context.cancelled || context.performed) {
            red.rectTransform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void OnGreenTap (InputAction.CallbackContext context) {
        if (context.started) {
            green.rectTransform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        } else if (context.cancelled || context.performed) {
            green.rectTransform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void OnFader (InputAction.CallbackContext context) {
        fader.rectTransform.anchoredPosition = new Vector2(((float)context.ReadValueAsObject()) * 150f, fader.rectTransform.anchoredPosition.y);
    }

    public void OnKnob (InputAction.CallbackContext context) {
        knob.rectTransform.localRotation = Quaternion.Euler(0, 0, ((float) context.ReadValueAsObject()) * -180);
    }

    public void OnEuphoria (InputAction.CallbackContext context) {
        if (context.started) {
            euphoria.rectTransform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        } else if(context.cancelled || context.performed) {
            euphoria.rectTransform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void OnTurntable (InputAction.CallbackContext context) {

        if (context.started || context.performed) {
            float value = (float) context.ReadValueAsObject();
            if(value < -threshold) {
                downArrow.enabled = true;
                upArrow.enabled = false;
            } else if(value > threshold) {
                upArrow.enabled = true;
                downArrow.enabled = false;
            }
        } else if(context.cancelled) {
            downArrow.enabled = false;
            upArrow.enabled = false;
        }
    }
}
