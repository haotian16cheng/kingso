using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChangeGround : Ground
{
    public float ratio;
    public override void OnPass(Circle circle)
    {
        base.OnPass(circle);
        circle.SetSpeed(circle.speed*ratio);
    }
}
