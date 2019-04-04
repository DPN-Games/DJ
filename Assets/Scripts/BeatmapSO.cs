using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Beatmap", menuName = "DJ/Create Beatmap")]
public class BeatmapSO : ScriptableObject {
    public string DisplayName;
    public float BPM;
    public float Minutes;
    public float Seconds;
    public float Length;

    public AudioClip Song;
    public Note[] Notes;

    public void CalculateLength() {
        if(Seconds >= 60) {
            return;
        }

        if(Minutes >= 60) {
            return;
        }

        Length = (Minutes * 60) + Seconds;
    }
}
