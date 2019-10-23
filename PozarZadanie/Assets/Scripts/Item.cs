using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeItem {helmet, armor, legs}

public class Item : MonoBehaviour
{
    public TypeItem type;

    [SerializeField]
    private GameObject item;

    public void ShowOnPlayer()
    {
        item.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
