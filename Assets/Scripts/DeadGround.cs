using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadGround : Ground
{
    public override void OnBounce(Circle circle)
    {
        circle.Reset();
    }
    public override void OnPass(Circle circle)
    {
        circle.Reset();
    }
}
