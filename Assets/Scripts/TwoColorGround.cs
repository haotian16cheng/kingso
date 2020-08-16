using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoColorGround : Ground
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "circle")
        {
            Circle circle = collision.transform.GetComponent<Circle>();
            Debug.Log(Vector2.SignedAngle(circle.rigidbody2D.velocity, new Vector2(Mathf.Cos(transform.eulerAngles.z), Mathf.Sin(transform.eulerAngles.z))));
            if (Vector2.SignedAngle(circle.rigidbody2D.velocity, new Vector2(Mathf.Cos(transform.eulerAngles.z), Mathf.Sin(transform.eulerAngles.z))) > 0)
            {
                if (circle.color == COLOR.BLKAC)
                {
                    OnPass(circle);
                }
                else if (circle.color == COLOR.WHITE)
                {
                    OnBounce(circle);
                }
            }
            else
            {
                if (circle.color == COLOR.BLKAC)
                {
                    OnBounce(circle);
                }
                else if (circle.color == COLOR.WHITE)
                {
                    OnPass(circle);
                }
            }
        }
    }
}
