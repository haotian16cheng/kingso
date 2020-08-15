using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedGround : Ground
{
    public float speed;
    public override void OnPass(Circle circle)
    {
        base.OnPass(circle);
        if(circle.speed<speed)
        {
            OnBounce(circle);
        }
    }
}
