using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

internal class BeatmapController : MonoBehaviour {

    AudioSource source;
    static List<Note> Notes = new List<Note>();

    float timeStart;
    public float noteSpeed;

    public delegate void NoteSpawnedEvent (NoteController note);
    public event NoteSpawnedEvent noteSpawnedEvent;

    private void Start () {
        source = gameObject.AddComponent<AudioSource>();
        source.volume = 0.25f;
    }

    internal void Init (BeatmapSO song) {
        source.clip = song.Song;
        Notes = new List<Note>(song.Notes);

        foreach(Note n in Notes) {
            n.time -= noteSpeed;
        }

        timeStart = Time.time + 5;
    }

    private void Update () {
        if (Notes == null) return;

        if (timeStart <= Time.time && !source.isPlaying) source.Play();

        var t = Time.time - timeStart;
        if(Notes.Exists(x => x.time <= t)) {
            var notes = Notes.FindAll(x => x.time <= t);
            foreach(var n in notes) {
                var noteData = n;
                var go = new GameObject("Note").AddComponent<NoteController>();
                go.Init(noteData, noteSpeed);

                noteSpawnedEvent?.Invoke(go);
            }

            Notes.RemoveAll(x => x.time <= t);
        }
    }

    [MenuItem("DJ/Create Note/Red _8")]
    static void CreateRedNote () {
        Notes.Add(new Note(0f, Note.NoteLane.Red));
    }

    [MenuItem("DJ/Create Note/Green _7")]
    static void CreateGreenNote () {
        Notes.Add(new Note(0f, Note.NoteLane.Green));
    }

    [MenuItem("DJ/Create Note/Blue _9")]
    static void CreateBlueNote () {
        Notes.Add(new Note(0f, Note.NoteLane.Blue));
    }
}

[CustomEditor(typeof(BeatmapController))]
internal class BeatmapControllerEditor : Editor {
    public BeatmapSO map;

    public override void OnInspectorGUI () {
        base.OnInspectorGUI();

        map = (BeatmapSO) EditorGUILayout.ObjectField(map, typeof(BeatmapSO));

        if (GUILayout.Button("Init")) {
            ((BeatmapController) target).Init(map);
        }
    }
}