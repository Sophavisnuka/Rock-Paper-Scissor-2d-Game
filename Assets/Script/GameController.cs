using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject mainPanel;
    public Image playerImage;
    public Image computerImage;
    public Sprite rockSprite;
    public Sprite paperSprite;
    public Sprite scissorSprite;
    public Sprite questionSprite;
    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;
    public TMP_Text endMessageText;
    int playerScore = 0;
    int computerScore = 0;
    public static bool playerWon = false;
    int GetComputerChoice()
    {
        return Random.Range(1, 4); // 1 = rock, 2 = paper, 3 = scissor
    }
    public void DisplayResult(int playerChoice)
    {
        int computerChoice = GetComputerChoice();
        playerImage.sprite = GetSpriteFromChoice(playerChoice);
        computerImage.sprite = GetSpriteFromChoice(computerChoice);
        CompareResult(playerChoice, computerChoice);
        Debug.Log("Computer Choice: " + computerChoice);
    }
    public void OnClickButton(GameObject buttonObject)
    {
        int yourResult = int.Parse(buttonObject.name.Substring(0,1));
        DisplayResult(yourResult);
    }
    Sprite GetSpriteFromChoice(int choice)
    {
        if (choice == 1) return rockSprite;
        if (choice == 2) return paperSprite;
        if (choice == 3) return scissorSprite;
        return questionSprite;
    }
    public void CompareResult(int player, int computer)
    {
        if (player == 1 && computer == 2 || player == 2 && computer == 3 || player == 3 && computer == 1)
        {
            computerScore++;
            computerScoreText.text = computerScore.ToString();
        }
        if (computer == 1 && player == 2 || computer == 2 && player == 3 || computer == 3 && player == 1)
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();
        }
        if (playerScore >= 5)
        {
            playerWon = true;
            SceneManager.LoadScene("EndScene");
        }
        if (computerScore >= 5)
        {
            playerWon = false;
            SceneManager.LoadScene("EndScene");
        }
    }
}
