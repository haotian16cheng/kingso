﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COLOR
{
    NONE,
    BLKAC,
    WHITE
}

public static class Const
{
    public static List<Vector2> cameraPosition = new List<Vector2>
    {
        new Vector2(11.6f ,0),
        new Vector2(30f, 0),
        new Vector2(),
        new Vector2(),
        new Vector2(),
        new Vector2(),
        new Vector2(),
    };
    public static List<string> levelNameList = new List<string>
    {
        "改变",
         "合作",
          "跳板",
           "对与错",
            "梦想",
             "视角",
              "阻力",
               "梦想"
    };
    public static List<int> levelFlagNum = new List<int> { 
        1,2,1,1,1,1,1,1,1,1,1,1,1
    };
}
