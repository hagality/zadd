using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private PlayerMovement playerMovement;

    [SerializeField]
    private PickUpItem[] items;

    [SerializeField]
    private Fire fire;

    [SerializeField]
    private MessagePanel messagePanel;

    [SerializeField]
    private GameObject LosePanel;

    [SerializeField]
    private GameObject WinPanel;

    private float timeOnMission = 120f, currentTime;
    private bool missionStarted = false;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(FireAlarm());
    }

    private void FixedUpdate()
    {
        if (!missionStarted)
            return;

        currentTime -= Time.deltaTime;
        fire.firePanel.SetValuesOnPanel(currentTime, timeOnMission);

        if (currentTime <= 0)
        {
            SetLose();
        }
    }

    private IEnumerator FireAlarm()
    {
        playerMovement.enabled = false;

        yield return new WaitForSeconds(1.5f);

        messagePanel.SetMessage("zgłoszono podpalenie ściany");
        messagePanel.Visible(true);

        yield return new WaitForSeconds(4f);

        messagePanel.SetMessage("Założ helm, i ubrania klikając na przedmioty żeby ugasić pożar");

        fire.Activation();

        currentTime = timeOnMission;

        missionStarted = true;


        yield return new WaitForSeconds(4f);

        messagePanel.SetMessage("Poruszanie wsad lub strzałkami, użycie gasnicy spacją");

        yield return new WaitForSeconds(4f);

        messagePanel.Visible(false);
        fire.firePanel.gameObject.SetActive(true);
        playerMovement.enabled = true;

        StartCoroutine(ShowItems());
    }

   private IEnumerator ShowItems()
    {
        for (int i=0; i<items.Length; i++)
        {
            items[i].gameObject.SetActive(true);
            yield return new WaitForSeconds(1f);
        }
    }



    public void ReloadScene()
    {
       SceneManager.LoadScene("main");
    }

    public void SetLose()
    {
        LosePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void SetWin()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
