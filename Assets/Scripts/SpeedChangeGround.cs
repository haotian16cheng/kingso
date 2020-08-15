using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChangeGround : Ground
{
    public float ratio;
    public override void OnPass(Collider2D collision)
    {
        Circle circle = collision.transform.GetComponent<Circle>();
        circle.SetSpeed(circle.speed*ratio);
    }
}
