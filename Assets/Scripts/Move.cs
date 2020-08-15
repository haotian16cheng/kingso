using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5;
    Vector2 veclocity = Vector2.zero;
    public Vector2 offset = Vector2.zero;
    public int num = 5;

    Vector2 startPosition;
    Vector2 endPosition;

    COLOR color = COLOR.BLKAC;
    Rigidbody2D rigidbody2D;
    bool start = true;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        veclocity = offset.normalized;
        startPosition = transform.position;
        endPosition = startPosition + offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (num > 0)
        {
            if (start)
            {
                rigidbody2D.velocity = veclocity * speed;
                if (math.abs(Vector2.Distance(transform.position, endPosition)) < 0.01)
                {
                    start = !start;
                    num--;
                    rigidbody2D.velocity = Vector2.zero;
                }
            }
            else
            {
                rigidbody2D.velocity = -veclocity * speed;
                if (math.abs(Vector2.Distance(transform.position, startPosition)) < 0.01)
                {
                    start = !start;
                    num--;
                    rigidbody2D.velocity = Vector2.zero;
                }
            }
        }
    }


}
