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
    public Slider slider;
    
    private Canvas settingCanvas;
    private Canvas MainCanvas;
    public TextMeshProUGUI loadingText;
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
        slider.value = 0;
        StartCoroutine(LoadScene());
    }
    private IEnumerator LoadScene(){
        canChange = false;
        var op = SceneManager.LoadSceneAsync(1);
        op.allowSceneActivation = false;
        while(op.progress < 0.9f){
            yield return null;
        }
        while(slider.value <= 0.7f){
            slider.value += Time.deltaTime;
            loadingText.text = "Loading" + (int)(slider.value * 100) + "%";
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        slider.value = 1;
        loadingText.text = "Loading" + (int)(slider.value * 100) + "%";
        yield return new WaitForSeconds(0.5f);
        slider.gameObject.SetActive(false);
        canChange = false;
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
