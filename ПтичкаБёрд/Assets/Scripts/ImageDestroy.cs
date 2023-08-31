using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDestroy : MonoBehaviour
{
    public float speed;
    public GameObject GamePlus;
    public GameObject Tap;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < GamePlus.transform.position.x)
        {
            Destroy(Tap);
        }
    }
}
