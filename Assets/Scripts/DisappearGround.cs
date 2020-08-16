using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearGround : Ground
{
    public float time;
    public override void OnBounce(Circle circle)
    {
        base.OnBounce(circle);
        gameObject.SetActive(false);
        if (time >= 0)
        {
            StartCoroutine(Countdown());
        }  
    }
    IEnumerator Countdown()
    {

        yield return new WaitForSeconds(time);
        gameObject.SetActive(true);
    }
}
