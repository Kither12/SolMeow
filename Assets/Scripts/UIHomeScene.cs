using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIHomeScene : MonoBehaviour
{   
    public Canvas settingCanvas;
    public Canvas gameModeCanvas;
    public Canvas menuCanvas;
    public CanvasGroup main;
    private void Start() {
        if(gameModeCanvas != null) gameModeCanvas.enabled = false;
        if(menuCanvas != null) menuCanvas.enabled = false;
        if(settingCanvas != null) settingCanvas.enabled = false;
    }
    public void Quit(){
        Application.Quit();
    }
    public void OpenStory(){
        SceneManager.LoadScene(2);
    }
    public void OpenGameMode(){
        gameModeCanvas.enabled ^= true;
        menuCanvas.enabled = false;
    }
    public void OpenMenu(){
        menuCanvas.enabled ^= true;
        gameModeCanvas.enabled = false;
    }
    public void OpenSetting(){
        main.interactable = false;
        menuCanvas.enabled = false;
        settingCanvas.enabled = true;
    }
    public void CloseSetting(){
        main.interactable = true;
        settingCanvas.enabled = false;
    }
}
