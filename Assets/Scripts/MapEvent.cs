using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[Serializable]
public class MapEvent {
    [SerializeField] internal float time;
    public EventType type;

    public MapEvent (EventType type, float time) {
    }
    
    public enum EventType {
        Note,
        Fade,
        Knob
    }
}