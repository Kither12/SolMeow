using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public Canvas CustomerInit;
    public Canvas PlayCanvas;
    public Canvas Setting;
    private void Start() {
        PlayCanvas.enabled = false;
        Setting.enabled = false;
        triggerCustomer();
    }
    public void triggerCustomer(){
        CustomerInit.enabled = true;
    }
    public void Play(){
        PlayCanvas.enabled = true;
        CustomerInit.enabled = false;
    }
    public void OpenSetting(){
        Setting.enabled ^= true;
    }
}
