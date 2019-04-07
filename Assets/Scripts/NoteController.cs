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

    internal void Init (Note data, float speed) {
        noteData = data;
        startPos = noteData.lane.Position();
        transform.position = startPos;
        endPos = startPos;
        endPos.y *= -1;
        endPos.y -= 1;

        timeStarted = Time.time;
        timeLength = speed;

        SpriteRenderer spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = NoteSprite;

        spriteRenderer.color = data.color.GetColorFromNoteColor();
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
