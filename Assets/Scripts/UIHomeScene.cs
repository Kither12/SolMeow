using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHomeScene : MonoBehaviour
{   
    public Canvas settingCanvas;
    public Canvas gameModeCanvas;
    public Canvas menuCanvas;
    public CanvasGroup main;
    public Animator MenuAnimator;
    public Canvas ShopPanel;
    public Image Header;
    public Sprite HeaderProduct, HeaderAcc;
    public GameObject AccItem, ProItem;
    public Canvas BuyConfirm;
    public Canvas Thanks;
    public static UIHomeScene instance;
    private ItemShop currentItem;
    public TextMeshProUGUI price;
    public Image icon;
    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }
    private void Start() {
        if(gameModeCanvas != null) gameModeCanvas.enabled = false;
        if(menuCanvas != null) menuCanvas.enabled = false;
        if(settingCanvas != null) settingCanvas.enabled = false;
        if(ShopPanel != null) ShopPanel.enabled = false;
        if(BuyConfirm != null) BuyConfirm.enabled = false;
        Thanks.enabled = false;
        Product();
    }
    public void CloseThank(){
        Thanks.enabled = false;
    }
    public void Buy(){
        currentItem.isBuy = true;
        currentItem = null;
        CloseConfirmation();
        Thanks.enabled = true;
    }
    public void OpenConfirmation(ItemShop item){
        currentItem = item;
        RectTransform rectTransform = (RectTransform)icon.transform;
        icon.sprite = item.Icon;

        rectTransform.sizeDelta = new Vector2(icon.sprite.texture.width / 4, icon.sprite.texture.height / 4);

        price.text = item.price.ToString();
        BuyConfirm.enabled = true;
    }
    public void CloseConfirmation(){
        BuyConfirm.enabled = false;
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
    public void OpenShop(){
        ShopPanel.enabled = true;
        menuCanvas.enabled = false;
        gameModeCanvas.enabled = false;
        settingCanvas.enabled = false;
        main.interactable = false;
    }
    public void CloseShop(){
        ShopPanel.enabled = false;
        menuCanvas.enabled = false;
        gameModeCanvas.enabled = false;
        settingCanvas.enabled = false;
        main.interactable = true;
    }
    public void Product(){
        Header.sprite = HeaderProduct;
        ProItem.SetActive(true);
        AccItem.SetActive(false);
    }
    public void Acc(){
        Header.sprite = HeaderAcc;
        ProItem.SetActive(false);
        AccItem.SetActive(true);
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
