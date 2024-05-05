using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement2 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        MoveLeft();
    }

    // Update is called once per frame
    void MoveLeft()
    {
        Vector2 leftDowewnDirection = Vector2.left + Vector2.down;
        leftDowewnDirection.Normalize();
        rb.AddForce(leftDowewnDirection * speed * Time.deltaTime, ForceMode2D.Impulse);
    }
}
