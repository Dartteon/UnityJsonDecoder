using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class JsonDetails<E> {

    public virtual void Init() {
        // Override if necessary
    }

    public virtual E GetEnumCode() {
        Debug.LogError("Override this please!");
        return default(E);
    }
}
