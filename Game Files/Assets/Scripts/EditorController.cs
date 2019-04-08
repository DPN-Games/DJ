// THIS FILE IS A FUCKING MESS BUT IDK HOW TO FIX IT WITHOUT A REWRITE
// REMIND ME IN A MONTH
// FUK IT REWRITE INCOMING

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EditorController : MonoBehaviour
{
    BeatmapSO currentBeatmap;
    Transform bars;
    Transform notes;

    public Sprite track;
    public Sprite snapSprite;

    public AudioSource music;
    public Slider slider;
    public Text time;
    new Camera camera;

    public float barCount;
    public float snap = 4;
    bool playing;

    void Start() {
        camera = Camera.main;
    }

    public void ShowTime() {
        time.gameObject.SetActive(true);
    }

    public void HideTime() {
        time.gameObject.SetActive(false);
    }

    void Update() {
        if (currentBeatmap == null) return;

        if (Input.GetKey(KeyCode.LeftControl)) {
            var size = camera.orthographicSize;
            size = Mathf.Clamp(size - Input.mouseScrollDelta.y, 10.24f, 40.96f);
            camera.orthographicSize = size;
        } else if (bars != null) {
            if (Input.mouseScrollDelta.y != 0) {
                camera.gameObject.transform.position = new Vector3(0, Mathf.Clamp(camera.gameObject.transform.position.y - Input.mouseScrollDelta.y, 0, barCount * 10.24f), -1);
                slider.value = GetTimeInSeconds();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!playing) {
                Play();
                playing = true;
            } else {
                playing = false;
                Stop();
            }
        }

        if (playing) {
            camera.gameObject.transform.position = new Vector3(0, (currentBeatmap.BPM / 60) * music.time * 10.24f, -1);
            slider.value = music.time;
        }

        if (time.gameObject.activeSelf) {
            time.text = $"{Mathf.FloorToInt(GetTimeInSeconds() / 60)}:{string.Format("{0:00}", Mathf.FloorToInt(GetTimeInSeconds() - (Mathf.Floor(GetTimeInSeconds() / 60) * 60)))}";
        }

        if (Input.GetMouseButtonDown(0)) {
            var pos = camera.ScreenToWorldPoint(Input.mousePosition);
            var lane = Mathf.RoundToInt(pos.x / 2.048f);
            var time = Mathf.Round((pos.y + 5.12f) / 10.24f * snap) / snap;

            if (lane < -2 || lane > 2) return;
            if (time < 0) return;

            currentBeatmap.AddNote(new Note(GetTimeInSeconds(time), lane));

            CreateNote(new Note(GetTimeInSeconds(time), lane));
        }

        if (Input.GetMouseButtonDown(1)) {
            var pos = camera.ScreenToWorldPoint(Input.mousePosition);
            var lane = Mathf.RoundToInt(pos.x / 2.048f);
            var time = Mathf.Round((pos.y + 5.12f) / 10.24f * snap) / snap;

            if (lane < -2 || lane > 2) return;
            if (time < 0) return;

            var size = currentBeatmap.Notes.Length;
            var notes = new List<Note>(currentBeatmap.Notes);
            notes.RemoveAll(x => x.time == GetTimeInSeconds(time) && x.lane == (Note.NoteLane)lane);
            if(size != notes.Count) {
                currentBeatmap.Notes = notes.ToArray();
                RefreshNotes();
            }
        }
    }

    void RefreshNotes() {
        ClearNotes();
        foreach (Note n in currentBeatmap.Notes) {
            CreateNote(n);
        }
    }

    void Play() {
        music.time = GetTimeInSeconds();
        music.Play();
    }

    void Stop() {
        music.Stop();
    }

    float GetTimeInSeconds() {
        return (camera.gameObject.transform.position.y / 10.24f) / (currentBeatmap.BPM / 60);
    }

    float GetTimeInSeconds(float time) {
        return (time / 10.24f) * (currentBeatmap.BPM / 60);
    }

    float GetTimeInBars() {
        return camera.gameObject.transform.transform.position.y / 10.24f;
    }

    float GetTimeInBars(float time) {
        return (time * 10.24f) / (currentBeatmap.BPM / 60);
    }

    public void LoadMap(BeatmapSO map) {
        currentBeatmap = map;
        Load();
    }

    void SliderChanged(float value) {
        if (!playing) {
            camera.gameObject.transform.position = new Vector3(0, (currentBeatmap.BPM / 60) * value * 10.24f, -1);
        }
    }

    void CreateNote(Note n) {
        var note = new GameObject($"{n.color}");

        var sprite = note.AddComponent<SpriteRenderer>();
        sprite.sprite = Resources.Load<Sprite>("Sprites/Note");
        sprite.color = n.color.GetColorFromNoteColor();

        var pos = Vector3.zero;
        pos.y = (GetTimeInBars(n.time) * 10.24f) - 5.12f;
        pos.x = (int)n.lane * 2.048f;
        pos.z = -0.1f;

        note.transform.localPosition = pos;
        note.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        note.transform.parent = notes;
    }

    void ClearNotes(bool remake = true) {
        DestroyImmediate(notes.gameObject);

        if (remake) {
            notes = new GameObject("Notes").transform;
            notes.parent = bars;
        }
    }

    public void ClearAll() {
        ClearNotes(false);
        Destroy(music.gameObject);
        Destroy(bars.gameObject);
    }

    void Load() {
        if (currentBeatmap != null) {
            if (currentBeatmap.Length == 0) currentBeatmap.CalculateLength();
            if (currentBeatmap.Length == 0) return;

            slider.maxValue = currentBeatmap.Length;
            slider.onValueChanged.AddListener(SliderChanged);

            barCount = (currentBeatmap.BPM / 60) * currentBeatmap.Length;

            bars = new GameObject("Bars").transform;

            for (int b = 0; b < Mathf.Ceil(barCount); b++){
                var obj = new GameObject($"{b}");
                obj.AddComponent<SpriteRenderer>().sprite = track;
                obj.transform.position = new Vector3(0, b * 10.24f, 0);
                obj.transform.parent = this.bars;

                var snap = new GameObject("Snap");
                snap.AddComponent<SpriteRenderer>().sprite = snapSprite;
                snap.transform.parent = obj.transform;
                snap.transform.localPosition = new Vector3(0, 0, -.05f);
            }

            notes = new GameObject("Notes").transform;
            notes.parent = bars;
            notes.localPosition = Vector3.zero;

            foreach(Note n in currentBeatmap.Notes) {
                CreateNote(n);
            }

            var musicObject = new GameObject("Audio");
            music = musicObject.AddComponent<AudioSource>();
            music.clip = currentBeatmap.Song;
        }
    }
}
[CustomEditor(typeof(EditorController))]
public class EditorControllerEditor : Editor
{
    public BeatmapSO map;

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        map = (BeatmapSO)EditorGUILayout.ObjectField(map, typeof(BeatmapSO));

        if(GUILayout.Button("Load Map")) {
            ((EditorController)target).LoadMap(map);
        }

        if (GUILayout.Button("Clear")) {
            ((EditorController)target).ClearAll();
        }
    }
}