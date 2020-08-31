using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoColorCircleGround : TwoColorGround
{
    public override void OnBounce(Circle circle)
    {
        Vector2 normal = transform.position - circle.transform.position;
        circle.rigidbody2D.velocity = Vector2.Reflect(circle.rigidbody2D.velocity, normal.normalized);
    }
}
