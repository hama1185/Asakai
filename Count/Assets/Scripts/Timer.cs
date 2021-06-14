using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public bool isRun = false;
    public float countTime;
    public float nowTime;
    UIManager uIManager;

    void Start(){
        uIManager = this.gameObject.GetComponent<UIManager>();
    }
    void Update(){
        if(isRun){
            // deltatimeから引いて更新していけばいいや
            countTime = countTime - Time.deltaTime;
            convertsec(countTime);
        }
        else{

        }

        if(countTime < 0 && isRun){
            // アラームを鳴らしてカウントを止める
            this.gameObject.transform.GetChild(0).GetComponent<AudioSource>().Play();
            isRun = false;
        }
    }

    public void startTimer(){
        isRun = true;
        countTime = fixsec(uIManager.hour, uIManager.min, uIManager.sec);
        nowTime = countTime;
    }

    public void stopTimer(){
        isRun = false;
    }

    public void convertsec(float count){
        int intCount = (int)Math.Round(count);
        var span = new TimeSpan(0,0,intCount);
        uIManager.changeTime(span.Hours, span.Minutes, span.Seconds);
    }

    public float fixsec(int hour, int min, int sec){
        return (hour * 3600 + min * 60 + sec);
    }
}