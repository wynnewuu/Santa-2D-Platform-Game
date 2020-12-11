using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Vector3 start;
    private Vector3 end;
    private bool movingRight = true;
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        start = new Vector3(20, 0, 70);
        end = new Vector3(-20, 0, 70);
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, start, speed * Time.deltaTime);
            if (transform.position.x >= 20)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, end, speed * Time.deltaTime);
            if (transform.position.x <= -20)
            {
                movingRight = true;
            }
        }
    }
}
