using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comamd_input : MonoBehaviour
{
    public List<souznic> souznics = new List<souznic>();
    public List<command_slot> command_Slots = new List<command_slot>();
    public void add(ActiveBehaiver souznic1, ActiveBehaiver hero)
    {
        souznics.Add(new souznic(souznic1, hero));
        Updatechar();
    }
    public void leave(ActiveBehaiver souznic1)
    {
        for (int i = 0; i < souznics.Count; i++)
        {
            if (souznics[i].character == souznic1)
            {
                souznics.RemoveAt(i);
            }
        }
        Updatechar();
    }
    public void newraund()
    {
        for (int i = 0; i < command_Slots.Count; i++)
        {
            command_Slots[i].work = false;
        }
        
    }
    public void delete(ActiveBehaiver souznic1)
    {
        for (int i = 0; i < souznics.Count; i++)
        {
            if (souznics[i].character == souznic1)
            {
                souznics[i].character.gameObject.AddComponent<autodelete>();
            }
        }
        Updatechar();
    }
    public void Updatechar()
    {
        for (int i = 0; i < souznics.Count; i++)
        {
            if (!souznics[i].character)
            {
                souznics.RemoveAt(i);
            }
        }
        
        
        for (int i2 = 0; i2 < command_Slots.Count; i2++)
        {

            
                command_Slots[i2].gameObject.AddComponent<autodelete>().plussdel();
            

        }
        command_Slots.Clear();
        for (int i = 0; i < souznics.Count; i++)
        {
            command_Slots.Add(Instantiate(Resources.Load<GameObject>("ui/command_slot"), transform).GetComponent<command_slot>());
            command_Slots[command_Slots.Count - 1].character = souznics[i].character;
        }


    }
}
