using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EditorController : MonoBehaviour
{
    BeatmapSO currentBeatmap;
    Transform bars;

    public Sprite track;
    public Sprite snapSprite;

    public AudioSource music;
    public Slider slider;
    new Camera camera;

    float barCount;
    bool playing;

    void Start() {
        camera = Camera.main;
    }

    void Update() {
        if (Input.GetKey(KeyCode.LeftControl)) {
            var size = camera.orthographicSize;
            size = Mathf.Clamp(size - Input.mouseScrollDelta.y, 5.12f, 20.48f);
            camera.orthographicSize = size;
        } else if (bars != null) {
            if (Input.mouseScrollDelta.y != 0) {
                bars.position = new Vector3(0, Mathf.Clamp(bars.position.y - Input.mouseScrollDelta.y, -barCount * 10.24f, 0), 0);
                slider.value = (-bars.position.y / 10.24f) / (currentBeatmap.BPM / 60);
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
            bars.position = new Vector3(0, (currentBeatmap.BPM / 60) * -music.time * 10.24f, 0);
            slider.value = music.time;
        }

        if (Input.GetMouseButtonDown(0)) {
            var pos = camera.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void Play() {
        music.time = (-bars.position.y / 10.24f) / (currentBeatmap.BPM / 60);
        music.Play();
    }

    void Stop() {
        music.Stop();
    }

    public void LoadMap(BeatmapSO map) {
        currentBeatmap = map;
        Load();
    }

    void SliderChanged(float value) {
        if (!playing) {
            bars.position = new Vector3(0, (currentBeatmap.BPM / 60) * -value * 10.24f, 0);
        }
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
                snap.transform.localPosition = Vector3.zero;
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
    }
}