using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    PlayerMovement playerMovement;

    private Animator anim;

    public Equipment eq;


    [SerializeField]
    private FireExtinguisher fireExtinguisher;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("FireMode");
            playerMovement.blocade = true;
            fireExtinguisher.StartUseFireExtinguisher();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetTrigger("WalkMode");
            playerMovement.blocade = false;
            fireExtinguisher.StopUseFireExtinguisher();
        }

        


    }

    private void OnTriggerEnter(Collider collider)
    {
       if (collider.CompareTag("FireRange"))
        {
            if (!eq.CheckItemsAreFounded())
            {
                GameManager.instance.SetLose();
            }
        }
    }

}
