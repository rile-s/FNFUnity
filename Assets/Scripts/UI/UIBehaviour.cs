﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBehaviour : MonoBehaviour {
    private RectTransform rect;

    public new RectTransform transform => rect;
    public Transform origTransform => base.transform;
    
    protected virtual void Awake() {
        rect = GetComponent<RectTransform>();
    }
}
