using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class unanimator : MonoBehaviour
{
    public float tic, time;
    public int tir;
    public Sprite[] sprites;
    public Sprite[] sprites1;
    public Sprite[] sprites2;
    public Sprite[] sprites3;
    public Sprite[] sprites4;
    public Sprite[,,] sprites5 = new Sprite[11, 11, 11];
    SpriteRenderer spriteRenderer;
    public int[] sst = new int[3]{0,1,2};
    public int min; public int max;
    public int sic;
    public string[] pathc, pathc1, pathc2;
    public int[] ixet;
    public int s = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        if (sic == 0)
        {
            sprites2 = Resources.LoadAll<Sprite>("uanim");

            sprites = new Sprite[sprites2.Length];
        }
        if (sic == 1)
        {
            sprites3 = Resources.LoadAll<Sprite>("uanim2");
            sprites = new Sprite[sprites3.Length];
        }
        if (sic == 2)
        {
            sprites4 = Resources.LoadAll<Sprite>("uanim3");
            sprites = new Sprite[sprites4.Length];
        }
        
        
        
        
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        udeyte();
    }

    // Update is called once per frame
    void Update()
    {
        if (sprites.Length != 0)
        {
            tic += 60 * Time.deltaTime;
            if (tic > time)
            {
                if (tir >= sprites.Length)
                {
                    tir = 0;
                }
                while (sprites[tir] == null)
                {
                    if (tir >= sprites.Length)
                    {
                        tir = 0;
                    }

                    tir++;
                    if (tir >= sprites.Length)
                    {
                        tir = 0;
                    }
                }
                
                if (sprites[tir] != null)
                {
                    spriteRenderer.sprite = sprites[tir];

                }
                
                
                tic = 0;
                tir++;

            }
        }
    }
    public void udeyte()
    {




        if (sic == 0)
        {

            for (int i = 0; i < sprites.Length; i++)
            {
                if (i >= min && i < max + 1)
                {


                    sprites[i] = sprites2[i];
                }
            }
        }
        if (sic == 1)
        {
            for (int i = 0; i < sprites.Length; i++)
            {
                if (i >= min && i < max + 1)
                {

                    sprites[i] = sprites3[i];
                }
            }
        }
        if (sic == 2)
        {
            for (int i = 0; i < sprites.Length; i++)
            {

                if (i >= min && i < max + 1)
                {
                    sprites[i] = sprites4[i];
                }
            }
        }
        bool sr = false; int sr2 = -1;
        for (int i = 0; i < sprites.Length; i++)
        {
            
                if (sr == false)
                {
                    if (sprites[i] != null)
                    {
                        sr = true;
                        sr2+= 1;
                    }
                }
                if (sr == true)
                {


                    sprites[i] = records2.spritest2(pathc[sr2], ixet[sr2], sprites[i]);
                    sr = false;
                }
            
            
        }

    }
}
