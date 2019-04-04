using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventType = MapEvent.EventType;

[Serializable]
public class Note : MapEvent
{
    [SerializeField] internal NoteColor color;
    [SerializeField] internal NoteLane lane;

    public Note (float time, NoteColor color, NoteLane lane) : base(EventType.Note, time) {
        this.color = color;
        this.lane = lane;
    }

    public enum NoteColor {
        Green = 1,
        Red = 2,
        Blue = 3
    }

    public enum NoteLane {
        GreenLeft = -2,
        Green = -1,
        Red = 0,
        Blue = 1,
        BlueRight = 2
    }
}
