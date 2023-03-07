using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private bool canChange = false;
    
    private Canvas settingCanvas;
    private Canvas MainCanvas;
    private void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(this);
        }
    }
    private void Start() {
        StartCoroutine(LoadScene());
    }
    private IEnumerator LoadScene(){
        canChange = false;
        var op = SceneManager.LoadSceneAsync(1);
        op.allowSceneActivation = false;
        while(op.progress < 0.9f){
            yield return null;
        }
        while(!canChange){
            yield return null;
        }
        op.allowSceneActivation = true;
        while(!op.isDone){
            yield return null;
        }
    }
    public void tap(){
        canChange = true;
    }
    public void exit(){
        Application.Quit();
    }
}
