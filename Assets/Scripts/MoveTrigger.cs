using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class MoveTrigger : MonoBehaviour
{
    public Shoot shoot;

    public Vector2 offset = Vector2.zero;

    public bool bAppear = true;

    public float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        shoot.setEvent(new UnityAction(trigger));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void trigger()
    {
        transform.DOLocalMove(new Vector2(transform.localPosition.x+offset.x, transform.localPosition.y + offset.y ), time);
        gameObject.SetActive(bAppear);
    }
}
