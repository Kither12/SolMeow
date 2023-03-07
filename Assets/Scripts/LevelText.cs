using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelText : MonoBehaviour
{
    private TextMeshProUGUI levelText;
    private void Awake() {
        levelText = GetComponent<TextMeshProUGUI>();
    }
    private void Update() {
        levelText.text = "Favor: " + GlobalPlayer.instance.winkie;
    }
}
