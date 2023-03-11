using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIHomeScene : MonoBehaviour
{
    public Canvas StoryMode;
    public Canvas gameModeCanvas;
    public Canvas Setting;
    private void Start() {
        if(StoryMode != null) StoryMode.enabled = false;
        if(gameModeCanvas != null) gameModeCanvas.enabled = false;
        if(Setting != null) Setting.enabled = false;
    }
    public void Quit(){
        Application.Quit();
    }
    public void OpenStory(){
        SceneManager.LoadScene(2);
    }
    public void OpenGameMode(){
        gameModeCanvas.enabled ^= true;
        Setting.enabled = false;
    }
    public void OpenSetting(){
        Setting.enabled ^= true;
        gameModeCanvas.enabled = false;
    }
}
