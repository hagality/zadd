using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private Item item;

    private void Awake()
    {
        item = GetComponent<Item>();
    }
    public void OnMouseDown()
    {
        Player player = GameObject.FindObjectOfType<Player>();

        player.eq.PutOn(item);

    }
}
