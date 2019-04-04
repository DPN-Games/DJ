using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

class NoteController : MonoBehaviour {

    [SerializeField] internal Note noteData;

    internal float distanceToFret;

    float timeStarted;
    float timeLength;

    Vector3 startPos;
    Vector3 endPos;

    Sprite NoteSprite;

    private void Awake () {
        NoteSprite = Resources.Load<Sprite>("Sprites/Note");
    }

    internal void Init (Note data) {
        noteData = data;
        startPos = noteData.lane.Position();
        endPos = startPos;
        endPos.y *= -1;
        endPos.y -= 1;

        timeStarted = Time.time;
        timeLength = 1f;

        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = NoteSprite;

        switch (data.color) {
            case Note.NoteColor.Blue:
                spriteRenderer.color = Color.blue;
                break;
            case Note.NoteColor.Red:
                spriteRenderer.color = Color.red;
                break;
            case Note.NoteColor.Green:
                spriteRenderer.color = Color.green;
                break;
        }
    }

    private void Update () {
        var t = (Time.time - timeStarted) / timeLength;
        transform.position = Vector3.Lerp(startPos, endPos, t);

        if(transform.position == endPos) {
            Destroy(gameObject);
        }

        distanceToFret = transform.position.y - 3;
    }
}
