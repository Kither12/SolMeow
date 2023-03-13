using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timing : MonoBehaviour
{
    public TextMeshProUGUI tmess;
    private void Update() {
        tmess.text = DateTime.Now.ToString("HH:mm");
    }
}
