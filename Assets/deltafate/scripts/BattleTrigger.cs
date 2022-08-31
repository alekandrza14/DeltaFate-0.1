using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class enemy
{
    public string enemyanim;
    public long hp; public long mp;
    public long tp;
    public act[] acts;
    public bool init;
    public enemy clone()
   {
       enemy en = new enemy();
        en.enemyanim = this.enemyanim;
        en.hp = this.hp;
        en.mp = this.mp;
        en.tp = this.tp;
        en.acts = this.acts;
        return en;
    }
}

public class BattleTrigger : MonoBehaviour
{
    public enemy en;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<PlayerControler>().b.en = en.clone();
        }
    }
}
