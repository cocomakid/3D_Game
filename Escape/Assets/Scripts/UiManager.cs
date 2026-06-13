using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    public GameObject Panel;

    public void GameButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenPanel()
    {
        Panel.SetActive(true);
    }
    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
}