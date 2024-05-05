using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public TMP_Text scoreTextPlayer1;
    public TMP_Text scoreTextPlayer2;

    public int goalToWin;

    void Update()
    {
        if(this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin)
        {
            Debug.Log("Game Won");
            SceneManager.LoadScene("GameOver2");
        }
    }

    private void FixedUpdate()
    {
        scoreTextPlayer1.text = this.scorePlayer1.ToString();

        scoreTextPlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }

}
