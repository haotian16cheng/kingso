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
            float angle = Vector2.SignedAngle(circle.rigidbody2D.velocity, Vector2.right);
            Debug.Log(transform.eulerAngles.z);
            if (angle < 180 ? transform.eulerAngles.z > angle && transform.eulerAngles.z < angle + 180 : transform.eulerAngles.z > angle || transform.eulerAngles.z < angle - 180)
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
