using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class guns33
{
    public static modefikatoritems mods = new modefikatoritems();
    public static void update()
    {
        if (File.Exists(@"mods/item2.un"))
        {
            mods = JsonUtility.FromJson<modefikatoritems>(File.ReadAllText(@"mods/item2.un"));
            for (int x = 0; x < mods.itemdamage.Count; x++)
            {


                IDdamage[x] = mods.itemdamage[x];


            }
        }
    }
    public static int[] IDdamage = new int[8]
    {
        1,//0
        17,//1
        0,//2
        2,//3
        20, //4
        1,
        1,
        1000

    }
    ; public static int[] IDdamagemagic = new int[8]
     {
        1,//0
        17,//1
        0,//2
        20,//3
        20, //4
        1,
        1,
        1000
     }
     ; public static Vector2[] IDeffect = new Vector2[8]
      {
          new Vector2(2,22),//0
          new Vector2(2,2),//1
          new Vector2(0,0),//2
          new Vector2(0,0),//3
          new Vector2(0,0),//4
        new Vector2(0,0),//5
        new Vector2(1,15),//6
        new Vector2(0,0)
      }
      ;
    public static Vector2[] idtic = new Vector2[8]
     {
        new Vector2(0,0),//0
        new Vector2(0,0),//1
        new Vector2(0,0),//2
        new Vector2(0,0),//3
        new Vector2(1,0),//4
        new Vector2(0,0),//5
        new Vector2(0,0),//6
        new Vector2(5,0),//7
        
     }
     ;
}
