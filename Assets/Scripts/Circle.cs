using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public int id = 0;
    public float startSpeed = 5;
    public float speed;
    public Vector2 velocity = new Vector2(0, -5);
    public COLOR color = COLOR.BLKAC;
    public bool circleLock = true;

    SpriteRenderer render;
    public Rigidbody2D rigidbody2D;

    bool reset = true;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
       // rigidbody2D.velocity = velocity.normalized*speed;
        string path = "white_circle";
        if (color == COLOR.BLKAC)
        {
            path = "black_circle";
        }
        Sprite sprite = Resources.Load<Sprite>(path);
        if (sprite == null)
        {
            Debug.LogError(name + "不存在");
        }
        render.sprite = sprite;
       // circleLock = true;
    }

    // Update is called once per frame
    void Update()
    {
       // this.gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "end")
        {
            Shoot shoot = collision.GetComponent<Shoot>();
            shoot.getDes();

            Debug.Log("通关");

            Vector2 position = collision.gameObject.transform.localPosition;
            this.gameObject.transform.position = position;
            rigidbody2D.velocity = Vector2.zero;
            reset = true;

            Manager.Instance.getDes();
            Manager.Instance.shootList[id] = shoot;
            collision.tag = "start";
        }
    }
    public void Reset()
    {
        reset = true;
        this.transform.localPosition = Manager.Instance.shootList[id].transform.localPosition;
        rigidbody2D.velocity = Vector2.zero;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "bg")
        {
            Reset();
        }
    }

    

    public void ChangeColor()
    {
        if (Manager.Instance.bLock||circleLock)
        {
            Debug.Log("锁定");
            return;
        }
        string path = "white_circle";
        switch (color)
        {
            case COLOR.BLKAC:
                color = COLOR.WHITE;
                break;
            case COLOR.WHITE:
                color = COLOR.BLKAC;
                path = "black_circle";
                break;
        }

        Sprite sprite = Resources.Load<Sprite>(path);
        if (sprite == null)
        {
            Debug.LogError(name + "不存在");
        }
        render.sprite = sprite;

        if (reset)
        {
            rigidbody2D.velocity = velocity.normalized * startSpeed;
            speed = startSpeed;
            reset = !reset;
        }
    }
    public void SetSpeed(float speed)
    {
        this.speed = speed;
        rigidbody2D.velocity = rigidbody2D.velocity.normalized * speed;
    }

}
