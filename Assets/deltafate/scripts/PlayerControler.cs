using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Save;

public class PlayerControler : MonoBehaviour
{
    public CameraMover _camera;
    public ActiveBehaiver character;
    public ActiveBehaiver[] othercharacters;
    List<ActiveBehaiver> othercharacterslist = new List<ActiveBehaiver>();
    public batlle b;
    void Start()
    {
        SaveDataClass.load(this);
        character.isMain = true;
        
    }
    void Update()
    {
        set();
        SaveDataClass.save(this);
        if (Input.GetKeyDown(KeyCode.F2))
        {
            create("character-2", character.transform.position,100,0,0);
        }
    }
    public void create(string name, Vector3 pos, long hp, long xp, long level)
    {
        othercharacterslist.Add(Instantiate(Resources.Load<GameObject>("characters/" + name), transform).GetComponent<ActiveBehaiver>());
        othercharacterslist[othercharacterslist.Count - 1].xp = xp;
        othercharacterslist[othercharacterslist.Count - 1].hp = hp;
        othercharacterslist[othercharacterslist.Count - 1].level = level;
        othercharacterslist[othercharacterslist.Count - 1].transform.position = pos;
        othercharacterslist[othercharacterslist.Count - 1].character = _camera.character;
        up();
    }
    public void set()
    {
        
            for (int i = 0; i < othercharacterslist.Count; i++)
            {
                if (!othercharacterslist[i])
                {
                    othercharacterslist.RemoveAt(i);
                }
            }
            up();
        
    }
        public void up()
    {
        othercharacters = new ActiveBehaiver[othercharacterslist.Count];
        for (int i =0;i< othercharacterslist.Count;i++)
        {
            othercharacters[i] = othercharacterslist[i];
        }
    }

}
