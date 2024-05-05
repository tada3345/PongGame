using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
public class WinnerCollider : MonoBehaviour
{
    [SerializeField] GameManager GM;

    void OnTriggerEnter2D()
    {
        Debug.Log("collided! " +  this.gameObject.name);

        if(this.gameObject.name == "Goal1")
        {
            GM.Win(1);
        }
        else
        {
            GM.Win(2);
        }
    }
}
