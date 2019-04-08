using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Input;
using System;
using System.Collections.Generic;

public class FretController : MonoBehaviour {

    [SerializeField] InputActions input;
    [SerializeField] internal Note.NoteColor color;
    Sprite pressedSprite;
    Sprite unpressedSprite;

    List<NoteController> notes = new List<NoteController>();

    new SpriteRenderer renderer;
    [SerializeField] LineRenderer laneLine;

    void Start () {
        renderer = GetComponent<SpriteRenderer>();

        pressedSprite = Resources.Load<Sprite>("Sprites/FretPressed");
        unpressedSprite = Resources.Load<Sprite>("Sprites/Fret");

        input.Game.BlueTap.started += StartBlue;
        input.Game.BlueTap.performed += EndBlue;
        input.Game.BlueTap.cancelled += EndBlue;

        input.Game.GreenTap.started += StartGreen;
        input.Game.GreenTap.performed += EndGreen;
        input.Game.GreenTap.cancelled += EndGreen;

        input.Game.RedTap.started += StartRed;
        input.Game.RedTap.performed += EndRed;
        input.Game.RedTap.cancelled += EndRed;
    }

    internal void AddNote (NoteController note) {
        if(!notes.Exists(x => note.noteData == x.noteData)) {
            notes.Add(note);
        }
    }
       
   

    void CheckHit () {
        if (notes.Count == 0) return;

        var noteToCheck = notes[0];

        if (noteToCheck == null) return;

        Debug.Log(noteToCheck.transform.position.y - transform.position.y);
        notes.Remove(noteToCheck);
    }

    private void OnEnable () {
        input.Enable();
    }

    private void OnDisable () {
        input.Disable();
    }

    private void EndRed (InputAction.CallbackContext obj) {
        if (color == Note.NoteColor.Red) {
            renderer.sprite = unpressedSprite;
        }
    }

    private void StartRed (InputAction.CallbackContext obj) {
        if (color == Note.NoteColor.Red) {
            renderer.sprite = pressedSprite;
            CheckHit();
        }
    }

    private void EndGreen (InputAction.CallbackContext obj) {
        if (color == Note.NoteColor.Green) {
            renderer.sprite = unpressedSprite;
        }
    }

    private void StartGreen (InputAction.CallbackContext obj) {
        if (color == Note.NoteColor.Green) {
            renderer.sprite = pressedSprite;
            CheckHit();
        }
    }

    private void EndBlue (InputAction.CallbackContext obj) {
        if (color == Note.NoteColor.Blue) {
            renderer.sprite = unpressedSprite;
        }
    }

    private void StartBlue (InputAction.CallbackContext obj) {
        if (color == Note.NoteColor.Blue) {
            renderer.sprite = pressedSprite;
            CheckHit();
        }
    }
}
