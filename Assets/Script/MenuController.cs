using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToRules()
    {
        SceneManager.LoadScene("GameRule");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
