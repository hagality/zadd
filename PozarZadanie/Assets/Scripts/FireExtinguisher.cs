using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    [SerializeField]
    private GameObject effect;

    private Fire fire;

    private bool active = false;

    private void Awake()
    {
        fire = GameObject.FindObjectOfType<Fire>();
    }

    public void StartUseFireExtinguisher()
    {
        active = true;
        effect.SetActive(true);
    }


    public void StopUseFireExtinguisher()
    {
        active = false;
        effect.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (active)
        {
            ShootRaycast();
        }
       
    }



    private void ShootRaycast()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 0.5f, layerMask))
        {
            if (hit.transform.CompareTag("Fire"))
            {
                fire.Hit();
            }
        }
    }
}


