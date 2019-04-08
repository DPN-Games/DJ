using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] FaderController fader;

    [SerializeField] FretController green;
    [SerializeField] FretController red;
    [SerializeField] FretController blue;

    [SerializeField] BeatmapController beatmap;

    void Start()
    {
        beatmap.noteSpawnedEvent += Beatmap_noteSpawnedEvent;
    }

    private void Beatmap_noteSpawnedEvent (NoteController note) {
        switch (note.noteData.color) {
            case Note.NoteColor.Green:
                green.AddNote(note);
                break;
            case Note.NoteColor.Red:
                red.AddNote(note);
                break;
            case Note.NoteColor.Blue:
                blue.AddNote(note);
                break;
        }
    }

    void Update()
    {
        
    }

}
