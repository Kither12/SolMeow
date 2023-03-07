using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPlayer : MonoBehaviour
{
    public static GlobalPlayer instance;
    public int level = 60;
    public int winkie = 0;
    public int favor = 5;

    private void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(this);
        }
    }
}
