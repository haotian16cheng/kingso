using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViscosityGround : MonoBehaviour
{
    public Collider2D groundCollider;
    public COLOR color;
    private void Awake()
    {
        groundCollider = transform.GetComponent<Collider2D>();
    }
    virtual public void OnBounce()
    {
        groundCollider.isTrigger = false;
    }
    virtual public void OnPass()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "circle")
        {
            Circle circle = collision.transform.GetComponent<Circle>();
            if (color != circle.color)
            {
                OnBounce();
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("碰撞开始");
        groundCollider.isTrigger = true;
    }
}
