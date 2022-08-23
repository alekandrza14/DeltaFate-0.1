using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class reynorguns
{
    public static modefikatoritems mods = new modefikatoritems();
    public static void update()
    {
        if (File.Exists(@"mods/item3.un"))
        {
            mods = JsonUtility.FromJson<modefikatoritems>(File.ReadAllText(@"mods/item3.un"));
            for (int x = 0; x < mods.itemdamage.Count; x++)
            {


                IDdamage[x] = mods.itemdamage[x];


            }
        }
    }
    public static int[] IDdamage = new int[22]
    {
        30,//0
        40,//1
        50,//2
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
        20,//13
        20,//14
        20,//15
        30,//16
        3000,//17
        28,//18
        20,//19
        100,//20
        2//21

    }
    ; public static int[] IDdamagemagic = new int[22]
     {
        50,//0
        60,//1
        70,//2
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
        20,//13
        20,//14
        20,//15
        30,//16
        1900,//17
        28,//18
        20,//19
        1000,//20
        2//21

     }
     ; public static int[] IDcountdamage = new int[22]
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
        1,//13
        1,//14
        1,//15
        1,//16
        1,//17
        1,//18
        1,//19
        1,//20
        2//21

      }
      ; public static int[] IDlessdamade = new int[22]
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
        2//21

      }
      ;
}
