using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHomeScene : MonoBehaviour
{
    public Canvas settingCanvas;
    public Canvas mainCanvas;
    public Canvas StoryMode;
    public Canvas gameModeCanvas;
    private void Start() {
        if(mainCanvas != null) mainCanvas.enabled = true;
        if(settingCanvas != null) settingCanvas.enabled = false;
        if(StoryMode != null) StoryMode.enabled = false;
        if(gameModeCanvas != null) gameModeCanvas.enabled = false;
    }
    public void setting(){
        settingCanvas.enabled = true;
        mainCanvas.enabled = false;
    }
    public void quitSetting(){
        settingCanvas.enabled = false;
        mainCanvas.enabled = true;
    }
    public void Quit(){
        Application.Quit();
    }
    public void OpenStory(){
        StoryMode.enabled = true;
        gameModeCanvas.enabled = false;
    }
    public void BackStory(){
        StoryMode.enabled = false;
        gameModeCanvas.enabled = true;
    }
    public void OpenGameMode(){
        mainCanvas.enabled = false;
        gameModeCanvas.enabled = true;
    }
    public void CloseGameMode(){
        mainCanvas.enabled = true;
        gameModeCanvas.enabled = false;
    }
}
