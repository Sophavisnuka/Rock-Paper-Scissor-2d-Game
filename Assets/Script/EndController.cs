using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndController : MonoBehaviour
{
    public TMP_Text resultText;
    void Start()
    {
        if (GameController.playerWon)
        {
            resultText.text = "You Win! Congratulation"; 
        } else
        {
            resultText.text = "You Lose! Try again";
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("StartScene");
    }
}
