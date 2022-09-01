using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class command_input_controller : Comamd_input
{
    int cur;
    public Sprite active, pasive, work, workandactive;
    public batlle b;
    private void Update()
    {
        if (DuoInput.right() && cur < souznics.Count - 1)
        {
            cur++;
        }

        if (DuoInput.left() && cur > 0)
        {
            cur--;
        }
        for (int i = 0;i<command_Slots.Count;i++)
        {
            if (i == cur)
            {
                if (true)
                {


                    command_Slots[i].im.sprite = active;
                }
                if (command_Slots[i].work)
                {
                    command_Slots[i].im.sprite = workandactive;
                }
                if (!command_Slots[i].work && DuoInput.Act())
                {
                    command_Slots[i].work = true;
                }
            }
            if (i != cur)
            {
                if (true)
                {
                    command_Slots[i].im.sprite = pasive;
                }
                if (command_Slots[i].work)
                {
                    command_Slots[i].im.sprite = work;
                }
            }
        }
        if (DuoInput.down() && cur < souznics.Count - 4)
        {
            cur += 3;
        }

        if (DuoInput.up() && cur > 3)
        {
            cur -= 3;
        }
        if (DuoInput.Сancellation())
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }

        if (DuoInput.Enter())
        {
            b.attack = true;
            int count =0;
            for (int i = 0; i < command_Slots.Count; i++)
            {
                int y1 = UnityEngine.Random.Range(0,2);
                if (command_Slots[i].work && y1 == 1)
                {
                    count++;
                    b.en.hp -= command_Slots[i].character.level + 1;
                }
                if (command_Slots[i].work && y1 == 0)
                {
                    count++;
                    b.en.mp -= 1;
                }


            }
            if (true)
            {
                if (count == 0)
                {
                    b.attack = false;
                    gameObject.SetActive(true);
                }

                newraund();
            }
            gameObject.SetActive(!gameObject.activeSelf);
        }

    }
}

