using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI Player1Score;
    public TextMeshProUGUI Player2Score;
    private int score1 = 0;
    private int score2 = 0;
    [SerializeField] Transform ballStartPosition;
    public Vector3 ballStartPos;
    public ButtonFunc BF;

    // Start is called before the first frame update
    void Start()
    {
        ballStartPos = ballStartPosition.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if(score1 >4 || score2 > 4)
        {
            BF.OnClickToGame(2);
        }
    }

    public void Win(int x)
    {
        if(x == 1)
        {
            score2++;
            Player2Score.text = score2.ToString();

        }
        else if(x == 2)
        {
            score1++;
            Player1Score.text = score2.ToString();
        }

        Reset();
    }

    public void Reset()
    {
        ballStartPosition.position = ballStartPos;
    }
}
