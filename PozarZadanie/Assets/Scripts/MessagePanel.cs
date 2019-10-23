using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MessagePanel : MonoBehaviour
{
    [SerializeField]
    private Text txt;


    public void SetMessage(string msg)
    {
        txt.text = msg;
    }

    public void Visible(bool value)
    {
        this.gameObject.SetActive(value);
    }



}
