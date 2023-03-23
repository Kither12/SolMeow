using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemShop : MonoBehaviour
{
    private Button buyButton;
    private Image Background;
    public Sprite NotBuySprite, BuySprite;
    public bool isBuy;
    public int price;
    public Sprite Icon;
    private void Awake() {
        Background = transform.GetComponent<Image>();
        buyButton = transform.GetChild(0).GetComponent<Button>();
        Icon = transform.GetChild(1).GetComponent<Image>().sprite;
    }
    private void Update() {
        if(isBuy){
            Background.sprite = BuySprite;
        }
        else{
            Background.sprite = NotBuySprite;
        }
    }
    private void Start() {
        buyButton.onClick.AddListener(delegate {Buy();});
    }
    private void Buy(){
        UIHomeScene.instance.OpenConfirmation(this);
    }
}
