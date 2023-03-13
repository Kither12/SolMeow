using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoryManager : MonoBehaviour
{
    public Canvas CustomerInit;
    public Canvas PlayCanvas;
    public Canvas Setting;
    public Canvas PauseMenu;
    public Canvas SettingPanel;
    public Canvas MainCanvas;
    public GameObject OkayButton;
    public TextMeshProUGUI Intro;
    public GameObject globalButton;
    public float WaitChar = 0.01f;
    public bool finish;
    private void Start() {
        PlayCanvas.enabled = false;
        Setting.enabled = false;
        PauseMenu.enabled = false;
        SettingPanel.enabled = false;
        CustomerInit.enabled = false;
        MainCanvas.enabled = false;
        finish = false;
        StartCoroutine(triggerCustomer());
    }
    private IEnumerator triggerCustomer(){
        yield return new WaitForSeconds(0.5f);
        CustomerInit.enabled = true;
        OkayButton.SetActive(false);
        string temp = Intro.text;
        Intro.text = "";
        foreach(char c in temp){
            Intro.text += c;
            if(finish){
                Intro.text = temp;
                break;
            }
            yield return new WaitForSeconds(WaitChar);
        }
        globalButton.SetActive(false);
        OkayButton.SetActive(true);
    }
    public void Skip(){
        finish = true;
    }
    public void Play(){
        PlayCanvas.enabled = true;
        CustomerInit.enabled = false;
        MainCanvas.enabled = true;
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
