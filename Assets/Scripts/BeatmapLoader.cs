using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BeatmapLoader {

    static void LoadSong(BeatmapSO song) {
        SceneManager.LoadScene("Game");
        new GameObject("Beatmap").AddComponent<BeatmapController>().Init(song);
    }
}
