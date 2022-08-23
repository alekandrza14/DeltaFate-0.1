using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class guns
{
    public static modefikatoritems mods = new modefikatoritems();
    public static void update()
    {
        if (File.Exists(@"mods/item.un"))
        {
            mods = JsonUtility.FromJson<modefikatoritems>(File.ReadAllText(@"mods/item.un"));
            for (int x = 0; x < mods.itemdamage.Count; x++)
            {


                IDdamage[x] = mods.itemdamage[x];


            }
        }
    }
    public static int[] IDdamage = new int[25]
    {
        6,//0
        10,//1
        12,//2
        12,//3
        16,//4
        16,//5
        18,//6
        12,//7
        14,//8
        40,//9
        100,//10
        60,//11
        6,//12
        400,//13
        20,//14
        20,//15
        30,//16
        3000,//17
        28,//18
        20,//19
        100,//20
        2,//21
        0,
        0,
        100000
    }
    ; public static int[] IDdamagemagic = new int[25]
     {
        6,//0
        10,//1
        12,//2
        12,//3
        16,//4
        16,//5
        18,//6
        12,//7
        14,//8
        40,//9
        200,//10
        0,//11
        6,//12
        400,//13
        20,//14
        20,//15
        30,//16
        1900,//17
        28,//18
        20,//19
        1000,//20
        2,//21
        0,
        0,0
     }
     ; public static int[] IDcountdamage = new int[25]
      {
        1,//0
        1,//1
        1,//2
        1,//3
        1,//4
        1,//5
        3,//6
        1,//7
        1,//8
        1,//9
        3,//10
        1,//11
        1,//12
        7,//13
        1,//14
        1,//15
        1,//16
        1,//17
        1,//18
        1,//19
        1,//20
        2,//21
        0,
        0,0

      }
      ; public static int[] IDlessdamade = new int[25]
      {
        1,//0
        1,//1
        1,//2
        1,//3
        1,//4
        1,//5
        18,//6
        1,//7
        1,//8
        1,//9
        1,//10
        1,//11
        1,//12
        1,//13
        1,//14
        1,//15
        1,//16
        1,//17
        1,//18
        1,//19
        1,//20
        2,//21
        0,
        0,0
      }
      ; public static Vector2[] ideffect = new Vector2[25]
      {
        new Vector2(0,0),//0
        new Vector2(0,0),//1
        new Vector2(0,0),//2
        new Vector2(0,0),//3
        new Vector2(1,4),//4
        new Vector2(0,0),//5
        new Vector2(0,0),//6
        new Vector2(2,46),//7
        new Vector2(0,0),//8
        new Vector2(0,0),//9
        new Vector2(0,0),//10
        new Vector2(0,0),//11
        new Vector2(0,0),//12
        new Vector2(0,0),//13
        new Vector2(2,14),//14
        new Vector2(0,0),//15
        new Vector2(0,0),//16
        new Vector2(0,0),//17
        new Vector2(0,0),//18
        new Vector2(0,0),//19
        new Vector2(0,0),//20
        new Vector2(0,0),//21
        new Vector2(2,1),//22
        new Vector2(0,0)//23
                        ,new Vector2(0,0)//23
      }
      ; public static Vector2[] idtic = new Vector2[25]
      {
        new Vector2(0,0),//0
        new Vector2(0,0),//1
        new Vector2(0,0),//2
        new Vector2(0,0),//3
        new Vector2(0,0),//4
        new Vector2(0,0),//5
        new Vector2(2,0),//6
        new Vector2(0,0),//7
        new Vector2(0,0),//8
        new Vector2(0,0),//9
        new Vector2(0,0),//10
        new Vector2(0,0),//11
        new Vector2(0,0),//12
        new Vector2(0,0),//13
        new Vector2(0,0),//14
        new Vector2(0,0),//15
        new Vector2(0,0),//16
        new Vector2(0,0),//17
        new Vector2(0,0),//18
        new Vector2(0,0),//19
        new Vector2(0,0),//20
        new Vector2(0,0),//21
        new Vector2(0,0),//22
        new Vector2(0,0)//23
                        ,new Vector2(0,0)//23
      }
      ;
}
