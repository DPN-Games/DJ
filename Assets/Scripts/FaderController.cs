using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class FaderController : MonoBehaviour
{
    [SerializeField] InputActions input;

    FretController green;
    FretController blue;

    Vector3 greenStart = new Vector3(-3, 3, 1);
    Vector3 greenEnd = new Vector3(-6, 3, 1);

    Vector3 blueStart = new Vector3(3, 3, 1);
    Vector3 blueEnd = new Vector3(6, 3, 1);

    [Range(0, 1)]
    public float threshold;

    [Range(0, 2)]
    public float fadeTime;

    int currentFade = 0;
    float startTime;
    
    void Start()
    {
        List<FretController> FretControllers = new List<FretController>(Resources.FindObjectsOfTypeAll<FretController>());
        green = FretControllers.Find(x => x.color == Note.NoteColor.Green);
        blue = FretControllers.Find(x => x.color == Note.NoteColor.Blue);

        input.Game.Fader.performed += Fader;
    }

    private void Fader (InputAction.CallbackContext obj) {
        float value = (float) obj.ReadValueAsObject();
        if (value < -threshold) {
            if (currentFade != -1)
                startTime = Time.time;

            currentFade = -1;
        } else if(value > threshold) {
            if (currentFade != 1)
                startTime = Time.time;

            currentFade = 1;
        } else {
            if (currentFade != 0)
                startTime = Time.time;

            currentFade = 0;
        }
    }

    private void Update () {
        var t = (Time.time - startTime) / fadeTime;
        var greendistanceLeft = Mathf.InverseLerp(0, 3, -green.transform.localPosition.x - -greenStart.x);
        var bluedistanceLeft = Mathf.InverseLerp(0, 3, blue.transform.localPosition.x - blueStart.x);

        switch (currentFade) {
            case -1:
                if (green.transform.localPosition != greenEnd) {
                    green.transform.localPosition = Vector3.Lerp(greenStart, greenEnd, t / (1 - greendistanceLeft));
                }

                if (blue.transform.localPosition != blueStart) {
                    blue.transform.localPosition = Vector3.Lerp(blueEnd, blueStart, t / bluedistanceLeft);
                }

                break;
            case 1:
                if (blue.transform.localPosition != blueEnd) {
                    blue.transform.localPosition = Vector3.Lerp(blueStart, blueEnd, t / (1 - bluedistanceLeft));
                }

                if (green.transform.localPosition != greenStart) {
                    green.transform.localPosition = Vector3.Lerp(greenEnd, greenStart, t / greendistanceLeft);
                }
                break;
            case 0:
                if(green.transform.localPosition != greenStart) {
                    green.transform.localPosition = Vector3.Lerp(greenEnd, greenStart, t / greendistanceLeft);
                }

                if (blue.transform.localPosition != blueStart) {
                    blue.transform.localPosition = Vector3.Lerp(blueEnd, blueStart, t / bluedistanceLeft);
                }
                break;
        }
    }
}
