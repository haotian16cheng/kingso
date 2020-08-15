using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : Singleton<Manager>
{

    public List<Shoot> shootList = new List<Shoot>();

    public Text curFlagNum;
    public Text totalFlagNum;

    public int curNNum = 0;
    public int totalNNum = 0;

    public int level = 0;

    public bool bLock = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getDes()
    {
        curNNum++;
        updateFlag(curNNum, totalNNum);
        if (curNNum >= totalNNum)
        {
            level++;
            Move();
        }
    }

    public void setTotalNum(int num)
    {
        curNNum = num;
        updateFlag(curNNum, totalNNum);
    }

    public void updateFlag(int x, int y)
    {
        curNNum = x;
        totalNNum = y;

        curFlagNum.text = x.ToString();
        totalFlagNum.text = y.ToString();
    }

    public void Move()
    {
        bLock = true;
        switch (level)
        {
            case 1:
                MoveCamera(Const.cameraPosition[level - 1]);
                break;
        }
    }

    private void MoveCamera(Vector2 position)
    {
        Camera.main.transform.Translate(position);

    }
}
