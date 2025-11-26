using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndController : MonoBehaviour
{
    public GameObject winImage;
    public GameObject loseImage;
    public TMP_Text resultText;
    void Start()
    {
        if (GameController.playerWon)
        {
            resultText.text = "You Win! Congratulation"; 
            winImage.SetActive(true);

            if (loseImage != null) {
                loseImage.SetActive(false);
            }
        } else  {
            resultText.text = "You Lose! Try again";
            loseImage.SetActive(true);
            if (winImage != null) {
                winImage.SetActive(false);
            }
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
