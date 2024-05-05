using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform Ball;
    public float moveSpeed = 3.0f;
    float max_y_position = 2.71f;
    float min_y_position = -2.64f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = new Vector3(currentPosition.x, Ball.position.y, currentPosition.z);
        if(targetPosition.y > max_y_position || targetPosition.y < min_y_position)
        {
            return;
        } 
        transform.position = Vector3.Lerp(currentPosition, targetPosition, moveSpeed);  
        
    }
}
