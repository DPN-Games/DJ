using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static Note;

static class Extensions {
    public static Vector3 Position (this NoteLane lane) {
        return new Vector3((int) lane * 3, 10);
    }

    public static NoteColor GetColorFromLane(this int lane) {
        if (lane < -2 || lane > 2) return NoteColor.Red;

        switch (lane) {
            case -2:
                return NoteColor.Green;
            case -1:
                return NoteColor.Green;
            case 0:
                return NoteColor.Red;
            case 2:
                return NoteColor.Blue;
            case 1:
                return NoteColor.Blue;
            default:
                return NoteColor.Red;
        }
    }

    public static Color GetColorFromNoteColor(this NoteColor noteColor) {
        switch (noteColor) {
            case Note.NoteColor.Blue:
                return Color.blue;
            case Note.NoteColor.Red:
                return Color.red;
            case Note.NoteColor.Green:
                return Color.green;
            default:
                return Color.white;
        }
    }
}

