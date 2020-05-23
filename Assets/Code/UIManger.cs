using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    private static UIManger instance = null;
    public static UIManger inst { get { return instance; } }

    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;
    public GameObject CreditsPanel;
    public GameObject GameOverPanel;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        instance = null;
    }

    //This loads the panels in as it is called
    public void LoadPanel(GameObject Panel)
    {
        ClosePanel();
        Panel.SetActive(true);
    }

    //Sets all panels to false to ensure they close
    public void ClosePanel()
    {
        MainMenuPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        GameOverPanel.SetActive(false);
    }

    //Exit out of the game
    public void ExitGame()
    {
        Application.Quit();
    }
}
