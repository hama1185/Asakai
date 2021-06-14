using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManger : MonoBehaviour
{
    public GameObject SettingVolume;
    public bool timerFlag = false;
    Timer timer;
    UIManager uIManager;
    // Start is called before the first frame update
    void Start(){
        timer = this.gameObject.GetComponent<Timer>();
        uIManager = this.gameObject.GetComponent<UIManager>();
    }

    public void onClickStartButton(){
        if(timerFlag){
            // ストップ
            timer.stopTimer();
            timerFlag = false;
        }
        else{
            // スタート
            timer.startTimer();
            timerFlag = true;
        }
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
    public void onClickClearButton(){
        uIManager.updateTime();
        timer.stopTimer();
        timerFlag = false;
    }
    
}
