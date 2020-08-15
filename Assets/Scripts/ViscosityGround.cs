using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViscosityGround : Ground
{
    public override void OnPass(Circle circle)
    {
        base.OnPass(circle);
        float angle = Vector2.Angle(new Vector2(Mathf.Cos((float)transform.eulerAngles.z * Mathf.PI / 180), -Mathf.Sin((float)transform.eulerAngles.z * Mathf.PI / 180)), circle.rigidbody2D.velocity);
        if (angle > 0 && angle < 180)
        {
            circle.rigidbody2D.velocity = new Vector2(Mathf.Sin((float)transform.eulerAngles.z * Mathf.PI / 180), -Mathf.Cos((float)transform.eulerAngles.z * Mathf.PI / 180)) * circle.speed;
        }
        else
        {
            circle.rigidbody2D.velocity = new Vector2(-Mathf.Sin((float)transform.eulerAngles.z * Mathf.PI / 180), Mathf.Cos((float)transform.eulerAngles.z * Mathf.PI / 180)) * circle.speed;
        }
    }
}
