using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class buttonact
{
    public Sprite active;
    public Sprite passive;
    public Image im;
    public string typeaction;
}

public class batlle : MonoBehaviour
{
    public Canvas c;
    public buttonact[] ba;
    public int cur;
    public Animator anim;
    public Animator anim2;
    public PlayerControler pc;
    public Scrollbar sc;
    public Image im;
    public enemy en;
    public bool playert;
    public bool attack;
    float tic; float tic2;
    public Text txt;
    public SpriteRenderer player;
    public SpriteRenderer fight;

    private void Start()
    {
        c.enabled = false;
    }

    void Update()
    {
        if (en == null)
        {
            c.enabled = false;
        }
        if (en != null)
        {
            c.enabled = true;
            anim2.Play(en.enemyanim);
            if (en.hp <= 0)
            {
                en = null;
            }
            if (en.mp <= 0)
            {
                txt.text = "противник больше не агресивный";
            }
            if (en.mp > 0)
            {
                txt.text = "противник очень агресивный";
            }
            if (attack)
            {
                tic += Time.deltaTime; 
                tic2 += Time.deltaTime;
                if (tic < en.tp)
                {
                    if (tic2 > 0.5f)
                    {
                        pc.character.hp--;
                        tic2 = 0;
                    }
                    fight.enabled = true;
                }
                if (tic > en.tp)
                {
                    fight.enabled = false;
                    attack = false;
                }
            }
        }
        if (!attack)
        {
            tic = 0;
        }

        if (Input.GetKeyDown(KeyCode.D) && cur < ba.Length - 1)
        {
            cur++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && cur < ba.Length - 1)
        {
            cur++;
        }
        if (Input.GetKeyDown(KeyCode.A) && cur > 0)
        {
            cur--;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && cur > 0)
        {
            cur--;
        }
        ba[cur].im.sprite = ba[cur].active;
        for (int i =0;i<ba.Length;i++)
        {
            if (i != cur)
            {
                ba[i].im.sprite = ba[i].passive;
            }
            if (ba[i].typeaction == "attack" && Input.GetKeyDown(KeyCode.Return) && i == cur && !attack)
            {
                anim.Play("shoot"); if (en != null)
                {
                    attack = true;
                    en.hp -= 1;
                }
            }
            if (ba[i].typeaction == "attack" && Input.GetKeyDown(KeyCode.Z) && i == cur && !attack)
            {
                anim.Play("shoot"); if (en != null)
                {
                    attack = true;
                    en.hp -= 1;
                }
            }
            if (ba[i].typeaction == "act" && Input.GetKeyDown(KeyCode.Return) && i == cur && !attack)
            {
                anim.Play("hey"); if (en != null)
                {
                    attack = true;
                    en.mp -= 1;
                }
            }
            if (ba[i].typeaction == "act" && Input.GetKeyDown(KeyCode.Z) && i == cur && !attack)
            {
                anim.Play("hey"); if (en != null)
                {
                    attack = true;
                    en.mp -= 1;
                }
            }
            if (ba[i].typeaction == "spare" && Input.GetKeyDown(KeyCode.Return) && i == cur && !attack)
            {
                anim.Play("hey"); if (en != null)
                {
                    if (en.mp <= 0)
                    {
                        en = null;
                    }
                    if (en.mp > 0)
                    {
                        attack = true;
                        en.mp -= 1;
                    }
                }
            }
            if (ba[i].typeaction == "spare" && Input.GetKeyDown(KeyCode.Z) && i == cur && !attack)
            {
                anim.Play("hey"); if (en != null)
                {
                    if (en.mp <= 0)
                    {
                        en = null;
                    }
                    if (en.mp > 0)
                    {
                        attack = true;
                        en.mp -= 1;
                    }
                }
            }

        }
        
        player.enabled = c.enabled;
        System.Save.isata.onbatlle = c.enabled;
        if (pc.character.hp < pc.character.mhp / 10)
        {
            im.enabled = false;
        }
        else
        {
            im.enabled = true;
        }
        
            anim2.gameObject.SetActive(c.enabled);
        
        float hp= pc.character.hp
            , mhp= pc.character.mhp;
        sc.size = hp / mhp;
        if (Input.GetKeyDown(KeyCode.F3))
        {

            playert = true;
            c.enabled = !c.enabled;
            
        }
    }
}
