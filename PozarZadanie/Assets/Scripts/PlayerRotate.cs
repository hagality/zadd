using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public GameObject player;
    public Transform CamPoint;

    public float horizontalSpeed = 3.0F;

    private void Update()
    {

        if (Input.GetMouseButton(1))
        {
            player.transform.localEulerAngles = new Vector3(player.transform.localEulerAngles.x, CamPoint.localEulerAngles.y, player.transform.localEulerAngles.z);
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            CamPoint.transform.Rotate(0, h, 0);
        }


    }

}
