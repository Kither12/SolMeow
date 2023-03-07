using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinkieText : MonoBehaviour
{
    private TextMeshProUGUI winkieText;
    private void Awake() {
        winkieText = GetComponent<TextMeshProUGUI>();
    }
    private void Update() {
        winkieText.text = "Favor: " + GlobalPlayer.instance.winkie;
    }
}
