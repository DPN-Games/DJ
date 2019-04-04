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
}

