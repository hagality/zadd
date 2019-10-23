using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FirePanel : MonoBehaviour
{
    [SerializeField]
    private Text timeLeftTxt;

    [SerializeField]
    private Image timeLeftImg;

    [SerializeField]
    private Image countFireImg;


    public void SetValuesOnPanel(float currentTime, float maxTime)
    {
        timeLeftTxt.text = currentTime.ToString("F1");
        timeLeftImg.fillAmount = currentTime / maxTime;
    }


    public void SetCountFireOnPanel(float currentCount, float maxCount)
    {
        countFireImg.fillAmount = currentCount / maxCount;
    }

}
