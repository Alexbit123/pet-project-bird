using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed;
    public float GroundLengh;
    public int GroundCount;
    public GameObject GamePlus3;


    void Update()
    {
        
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < GamePlus3.transform.position.x)
        {
            transform.position = new Vector2(transform.position.x + GroundLengh * GroundCount, transform.position.y);
        }
    }
}
