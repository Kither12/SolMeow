using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Timing : MonoBehaviour
{
    public TextMeshProUGUI tmess;
    private Image image;
    public Sprite sun, moon;
    private void Start() {
        image = transform.parent.gameObject.GetComponent<Image>();
    }
    private void Update() {
        tmess.text = DateTime.Now.ToString("hh:mm tt");
        if(DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 18){
            image.sprite = sun;
        }
        else image.sprite = moon;
    }
}
