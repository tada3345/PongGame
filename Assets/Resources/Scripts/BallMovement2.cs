using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        MoveBallToLeft();
    }

    void MoveBallToLeft()
    {
        rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
    }
}
