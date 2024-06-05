using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerScoreText;
    public Text computerScoreText;
    private int playerScore;
    private int computerScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Exit
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void IncreatePlayerScore()
    {
        playerScore += 1;
        playerScoreText.text = playerScore.ToString();
    }

    public void IncreateComputerScore()
    {
        computerScore += 1;
        computerScoreText.text = computerScore.ToString();
    }
}
