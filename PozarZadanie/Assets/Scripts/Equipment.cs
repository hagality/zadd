using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class Equipment
{
    [SerializeField]
    private Item armor;

    [SerializeField]
    private Item legs;

    [SerializeField]
    private Item helmet;



    public bool CheckItemsAreFounded()
    {
        if (armor == null || legs == null || helmet == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void PutOn(Item item)
    {
        switch(item.type)
        {
            case TypeItem.armor:
                armor = item;
                break;

            case TypeItem.helmet:
                helmet = item;
                break;

            case TypeItem.legs:
                legs = item;
                break;
        }

        item.ShowOnPlayer();

    }
}
