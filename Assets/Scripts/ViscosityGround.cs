using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViscosityGround : Ground
{
    public override void OnPass(Circle circle)
    {
        base.OnPass(circle);
        Vector2 velocity = new Vector2(Mathf.Sin((float)transform.eulerAngles.z * Mathf.PI / 180), -Mathf.Cos((float)transform.eulerAngles.z * Mathf.PI / 180));
        if(Vector2.Angle(circle.rigidbody2D.velocity,velocity)>90)
        {
            velocity.x *= -1;
            velocity.y *= -1;
        }
        circle.rigidbody2D.velocity=velocity*circle.speed;
    }
}
