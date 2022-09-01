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

[System.Serializable]
public class act
{
    public string name;
    public string op;
    public Text txt;
    public Image soul;
    public long mp;
    public MonoBehaviour mb;
}

public class batlle : MonoBehaviour
{
    public Canvas c;
    public buttonact[] ba;
    public int cur;
    int acur;
    public Animator anim;
    public Animator anim2;
    public PlayerControler pc;
    public Scrollbar sc;
    public Image im;
    public enemy en;
    bool acting;
    public bool playert;
    public bool attack;
    float tic; float tic2; float tic3;
    public Text txt;
    public act[] acts;
    public bool ops;
    public SpriteRenderer player;
    public SpriteRenderer fight;
    public command_input_controller cic;

    private void Start()
    {
        c.enabled = false;
        en = null;
        for (int i = 0; i < acts.Length; i++)
        {
            acts[i].txt.text = "";
            
        }
    }
    public void actmb()
    {
        acting = true;
        if (DuoInput.right() && acur < acts.Length - 1)
        {
            acur++;
        }
        if (acts[acur].name == "")
        {
            acur--;
        }

        if (DuoInput.left() && acur > 0)
        {
            acur--;
        }
        if (DuoInput.Сancellation())
        {
            acting = false;
        }
        for (int i = 0; i < acts.Length; i++)
        {
            acts[i].txt.text = acts[i].name;
            if (i == acur)
            {
                acts[i].soul.color = new Color(1, 1, 1, 1);
            }
            if (i != acur)
            {
                acts[i].soul.color = new Color(1, 1, 1, 0);
            }
            if (i == acur && DuoInput.Enter())
            {
                if (acts[i].mb)
                {


                    acts[i].mb.enabled = true;
                }
                if (en != null)
                {
                    en.mp -= acts[i].mp;
                }
                attack = true;
                acting = false;
                txt.text = acts[i].op;
                ops = true;
            }

        }
    }
    public void noactmb()
    {
        
        for (int i = 0; i < acts.Length; i++)
        {
            acts[i].txt.text = "";
            
            
                acts[i].soul.color = new Color(1, 1, 1, 0);
            
            

        }
    }

    void Update()
    {
        if (acting)
        {
            actmb();

        }
        if (!acting)
        {
            noactmb();

        }
        if (en == null)
        {
            c.enabled = false;
        }
        if (en != null)
        {
            if (en.hp <= 0)
            {
                en = null;
            }
        }
        if (en != null)
        {
            if (!en.init)
            {
                for (int i = 0; i < en.acts.Length; i++)
                {
                    acts[i].name = en.acts[i].name;
                    acts[i].op = en.acts[i].op;
                    acts[i].mp = en.acts[i].mp;
                    acts[i].mb = en.acts[i].mb;
                    en.init = true;
                }
            }
            c.enabled = true;
            anim2.Play(en.enemyanim);

            if (DuoInput.Сancellation() && ops)
            {
                ops = false;
            }
            if (!ops)
            {


                if (en.mp <= 0)
                {
                    txt.text = "противник больше не агресивный";
                }
                if (en.mp > 0)
                {
                    txt.text = "противник очень агресивный";
                }
                if (en.mp > 3)
                {
                    txt.text = "противник растроен";
                }
                if (en.mp > 3 && en.hp > 10)
                {
                    txt.text = "противник в ярости похоже он вас убьёт";
                }
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
            if (!attack)
            {
                
                tic3 += Time.deltaTime;
                
                    if (tic3 > 1f)
                    {
                        pc.character.hp--;
                        tic3 = 0;
                    }
                   
                
            }
        }
        if (!attack)
        {
            tic = 0;
        }
        if (!acting && !cic.gameObject.activeSelf)
        {


            if (DuoInput.right() && cur < ba.Length - 1)
            {
                cur++;
            }

            if (DuoInput.left() && cur > 0)
            {
                cur--;
            }

            ba[cur].im.sprite = ba[cur].active;
            for (int i = 0; i < ba.Length; i++)
            {
                if (i != cur)
                {
                    ba[i].im.sprite = ba[i].passive;
                }
                if (ba[i].typeaction == "attack" && DuoInput.Enter() && i == cur && !attack)
                {
                    anim.Play("shoot"); if (en != null)
                    {
                        attack = true;
                        en.hp -= 1;
                    }
                }


                if (ba[i].typeaction == "act" && DuoInput.Enter() && i == cur && !attack)
                {
                    anim.Play("hey"); if (en != null)
                    {
                        acting = true;
                    }
                }
                if (ba[i].typeaction == "spare" && DuoInput.Enter() && i == cur && !attack)
                {
                    anim.Play("hey"); if (en != null)
                    {
                        if (en.mp > 0)
                        {
                            attack = true;
                            en.mp -= 1;
                        }
                        if (en.mp <= 0)
                        {
                            en = null;
                        }

                    }
                }
                if (ba[i].typeaction == "Help-comand" && DuoInput.Enter() && i == cur && !attack)
                {
                    anim.Play("hey"); if (en != null)
                    {
                        /*
                        for (int i2 =0;i2 < cic.command_Slots.Count;i++)
                        {

                        }
                        */
                        cic.gameObject.SetActive(!cic.gameObject.activeSelf);

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

            cic.gameObject.SetActive(!cic.gameObject.activeSelf);
            
        }
    }
}
