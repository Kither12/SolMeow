using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notification : MonoBehaviour
{
   public Sprite OnNoti, OffNoti;
   private Image img;
   private void Start() {
    img = GetComponent<Image>();
   }
   public void Click(){
        if(img.sprite == OnNoti) img.sprite = OffNoti;
        else img.sprite = OnNoti;
   }
}
