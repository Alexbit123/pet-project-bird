using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float speed;
    public float BackLengh;
    public int BackCount;
    
    public GameObject GamePlus;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < GamePlus.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + BackLengh * BackCount, transform.position.y);
        }
    }
}
