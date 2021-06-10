using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManger : MonoBehaviour
{
    public GameObject SettingVolume;
    // Start is called before the first frame update
    void Start(){
        
    }
    public void onClickSettingButton(){
        if(SettingVolume.activeSelf){
            SettingVolume.SetActive(false);
        }
        else{
            SettingVolume.SetActive(true);
        }
    }

    // クリアはスタート時のタイマーに戻ること

    
}
