using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Collider2D groundCollider;
    public COLOR color;
    private void Awake()
    {
        groundCollider = transform.GetComponent<Collider2D>();
    }
    virtual public void OnBounce(Circle circle)
    {
        groundCollider.isTrigger = false;
    }
    virtual public void OnPass(Circle circle)
    {
        circle.circleLock = true;
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "circle")
        {
            Circle circle = collision.transform.GetComponent<Circle>();
            if (color == circle.color)
            {
                OnPass(circle);
            }
            else
            {
                OnBounce(circle);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "circle")
        {
            collision.transform.GetComponent<Circle>().circleLock=false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("碰撞开始");
        groundCollider.isTrigger = true;
    }
}
