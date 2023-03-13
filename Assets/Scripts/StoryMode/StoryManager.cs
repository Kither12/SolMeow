using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public Canvas CustomerInit;
    public Canvas PlayCanvas;
    public Canvas Setting;
    public Canvas PauseMenu;
    public Canvas SettingPanel;
    private void Start() {
        PlayCanvas.enabled = false;
        Setting.enabled = false;
        PauseMenu.enabled = false;
        SettingPanel.enabled = false;
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
    public void OpenPauseMenu(){
        PauseMenu.enabled = true;
    }
    public void ClosePauseMenu(){
        PauseMenu.enabled = false;
    }
    public void OpenSettingPanel(){
        SettingPanel.enabled = true;
        Setting.enabled = false;
        PauseMenu.enabled = false;
    }
    public void CloseSettingPanel(){
        SettingPanel.enabled = false;
    }
    public void quit(){
        Application.Quit();
    }
}
