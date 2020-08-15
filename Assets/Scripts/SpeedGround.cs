using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedGround : Ground
{
    public float speed;
    public override void OnPass(Collider2D collision)
    {
        if(collision.transform.GetComponent<Circle>().speed<speed)
        {
            OnBounce(collision);
        }
    }
}
