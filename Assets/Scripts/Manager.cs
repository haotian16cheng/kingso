using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Manager : Singleton<Manager>
{

    public List<Shoot> shootList = new List<Shoot>();

    public Text curFlagNum;
    public Text totalFlagNum;

    public int curNNum = 0;
    public int totalNNum = 0;

    public int level = 0;

    public bool bLock = false;

    public GameObject bg;

    public Button button1;
    public Button button2;
    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        textAnimation();
        totalFlagNum.text = totalNNum.ToString();
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
        setButton1Visble(false);
        setButton2Visble(false);

        bLock = true;
        switch (level)
        {
            case 1:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
            case 2:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
            case 3:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
            case 4:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
            case 5:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
            case 6:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
            case 7:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
            case 8:
                {
                    MoveCamera(Const.cameraPosition[level - 1], () =>
                    {
                        setButton2Visble(true);
                        setButton1Visble(true);
                    });
                }
                break;
        }
    }

    private void MoveCamera(Vector2 position, TweenCallback call = null, float time = 1)
    {
        Tweener tweener =  Camera.main.transform.DOMove(new Vector3(position.x, position.y, Camera.main.transform.localPosition.z), time);
        tweener.onComplete += call;
        tweener.onComplete += ()=> {
            textAnimation();
            curNNum = 0;
            totalNNum = Const.levelFlagNum[level];
            updateFlag(curNNum, totalNNum);
            bLock = false;
        };
        //  bg.transform.DOMove(position, 1);
    }

    public void setButton1Visble(bool isB)
    {
        button1.gameObject.SetActive(isB);
    }
    public void setButton2Visble(bool isB)
    {
        button2.gameObject.SetActive(isB);
    }

    public void textAnimation()
    {
        levelText.text = Const.levelNameList[level];
        Sequence sequence = DOTween.Sequence();
        sequence.Append(levelText.DOFade(1, 0.5f));
        sequence.Append(levelText.DOFade(0, 1.8f));
    }
}
