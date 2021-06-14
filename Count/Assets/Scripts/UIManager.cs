using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Michsky.UI.ModernUIPack;
using Michsky;
using TMPro;

public class UIManager : MonoBehaviour
{
    // 時間
    public int hour = 1;
    public int min = 0;
    public int sec = 0;

    public GameObject hourSlider;
    public GameObject minSlider;
    public GameObject secSlider;
    public TMP_Text Time;

    // Start is called before the first frame update

    public void onChangeHourVolume(){
        hour = (int)hourSlider.GetComponent<Slider>().value;
        changeTime(hour, min, sec);
    }

    public void onChangeMinVolume(){
        min = (int)minSlider.GetComponent<Slider>().value;
        changeTime(hour, min, sec);
    }

    public void onChangeSecVolume(){
        sec = (int)secSlider.GetComponent<Slider>().value;
        changeTime(hour, min, sec);
    }

    public void updateTime(){
        Time.text = string.Format("{0:D2}",  hour) + ":" +
        string.Format("{0:D2}",  min) + ":" +
        string.Format("{0:D2}",  sec);
    }

    public void changeTime(int h, int m ,int s){
        Time.text = string.Format("{0:D2}",  h) + ":" +
        string.Format("{0:D2}",  m) + ":" +
        string.Format("{0:D2}",  s);
    }
}
