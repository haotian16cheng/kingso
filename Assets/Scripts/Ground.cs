using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Collider2D groundCollider;
    public COLOR color;
    private void Awake()
    {
        groundCollider = transform.GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "circle")
        {
            Circle circle = collision.transform.GetComponent<Circle>();
            if (color != circle.color)
            {
                groundCollider.isTrigger = false;
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("碰撞开始");
        groundCollider.isTrigger = true;
    }
}
