using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem fireParticle;

    public FirePanel firePanel;

    public float maxfireCount = 500f, currentCount;

    private void Awake()
    {
        currentCount = maxfireCount;
    }

    public void Activation()
    {
        fireParticle.gameObject.SetActive(true);
    }

    public void Hit()
    {
        currentCount--;


        if (currentCount <=0)
        {
            GameManager.instance.SetWin();
        }

        firePanel.SetCountFireOnPanel(currentCount, maxfireCount);
    }






}
