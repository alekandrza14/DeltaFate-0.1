using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBehaiver : MonoBehaviour
{
    public long hp = 100; 
    public long mhp = 100;
    public long xp;
    public long level;
    public command_input_controller cic;
    public string namecharacter;
   [HideInInspector] public bool isMain;
    [HideInInspector] public Transform character;
    [HideInInspector] public Vector3 traget;
    public float chardist = 5f;
    [HideInInspector] public Vector3 adirectoin;
    [HideInInspector] public float offset;
   public void Updateb()
   {
        adirectoin = Vector3.zero;
        if (hp <= 0)
        {
            if (isMain)
            {
                System.Save.SaveDataClass.fall(FindObjectOfType<PlayerControler>());
            }
            else
            {
                cic.leave(this);
                Destroy(gameObject);
            }
            
        }
        if (character)
        {


            float dist = Vector3.Distance(transform.position, character.position);
            if (dist > chardist)
            {
                Vector3 t = transform.position - character.position;
                adirectoin = t;
                t /= 300 / dist;
                if (traget.x == 0 && traget.y == 0)
                {
                    transform.position -= t;
                    transform.position = new Vector3(transform.position.x, transform.position.y, -offset);
                }

            }
            if (dist > chardist *3)
            {
                traget = Vector3.zero;
            }

        }
        if (traget.x != 0 && traget.y != 0)
        {


            float dist = Vector3.Distance(transform.position, traget);
            
                Vector3 t = transform.position - traget;
                adirectoin = t;
                t /= dist *20;
                transform.position -= t;
                transform.position = new Vector3(transform.position.x, transform.position.y, -offset);

            if (dist < 0.2f)
            {
                traget = Vector3.zero;
            }

        }
   }
    private void OnMouseDown()
    {
        if (character)
        {


            FindObjectOfType<CameraMover>().posledovatel = this;
        }
    }


}
