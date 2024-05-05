using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float move_increment = 0.1f;
    float max_y_position = 2.71f;
    float min_y_position = -2.64f;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        if (verticalInput  != 0) {
            Vector3 newPosition = transform.position + new Vector3(0, verticalInput * move_increment, 0);

            if(newPosition.y > max_y_position || newPosition.y < min_y_position)
            {
                return;
            }
            transform.position = newPosition;
        }
       

    }
}
