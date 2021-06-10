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

    // Start is called before the first frame update

    public void onChangeHourVolume(){
        hour = (int)hourSlider.GetComponent<Slider>().value;
    }

    public void onChangeMinVolume(){
        
    }

    public void onChangeSecVolume(){
        
    }
}
