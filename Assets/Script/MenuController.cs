using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame(GameObject buttonObject)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
