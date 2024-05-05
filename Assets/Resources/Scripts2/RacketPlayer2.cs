using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Random;

public class RacketPlayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int movementSpeed = 200;
    //public static float Range(int min, int max);
    private GameObject ball;

    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float targetPosition = ball.transform.position.y;
        float RandomNum = Random.Range(0f, 100f);

        if(RandomNum < 2.0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3 (transform.position.x, targetPosition, transform.position.z), movementSpeed);
        }
        //float userInput = Input.GetAxisRaw("Vertical2");
        //this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, userInput) * movementSpeed;
    }
}
