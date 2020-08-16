using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearGround : Ground
{
    public float time;
    public override void OnBounce(Circle circle)
    {
        base.OnBounce(circle);
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
        if(time>=0)
        {
            yield return new WaitForSeconds(time);
            gameObject.SetActive(true);
        }
    }
}
