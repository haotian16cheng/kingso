using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private Collider2D groundCollider;
    public COLOR color;
    private void Awake()
    {
        groundCollider = transform.GetComponent<Collider2D>();
    }
    public virtual void OnBounce(Circle circle)
    {
        //groundCollider.isTrigger = false;
        Debug.Log("方向改变");
         circle.rigidbody2D.velocity=Vector2.Reflect(circle.rigidbody2D.velocity, new Vector2(Mathf.Sin((float)transform.eulerAngles.z * Mathf.PI / 180), -Mathf.Cos((float)transform.eulerAngles.z * Mathf.PI / 180)));
    }
    public virtual void OnPass(Circle circle)
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
