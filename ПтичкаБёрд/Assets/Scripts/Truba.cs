using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truba : MonoBehaviour
{
    public float speed;
    public float TrubaLengh;
    public int TrubaCount;
    public GameObject GamePlus2;

    void Start()
    {
        Vector2 position = transform.position;
        position.y = Random.Range(3.4F, 7.1F);
        transform.position = position;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
        if (transform.position.x < GamePlus2.transform.position.x)
        {
            transform.position = new Vector2(transform.position.x + TrubaLengh * TrubaCount, transform.position.y);
            Vector3 position = transform.position;
            position.y = Random.Range(3.4F, 7.1F);
            transform.position = position;
        }
    }
}
