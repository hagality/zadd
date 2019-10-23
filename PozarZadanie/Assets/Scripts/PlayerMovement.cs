using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform CamPoint;
    private Animator anim;

    public bool blocade = false;

    public float horizontal, vertical;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    public void Update()
    {
        if (!blocade)
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
        }

        anim.SetFloat("x", horizontal);
        anim.SetFloat("z", vertical);




    }

    public void FixedUpdate()
    {

    }
}
