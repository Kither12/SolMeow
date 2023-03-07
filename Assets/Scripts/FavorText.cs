using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FavorText : MonoBehaviour
{
    private TextMeshProUGUI favorText;
    private void Awake() {
        favorText = GetComponent<TextMeshProUGUI>();
    }
    private void Update() {
        favorText.text = "Favor: " + GlobalPlayer.instance.favor;
    }
}
