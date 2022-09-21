using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.IO;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace System.Save
{
    public class isata
    {
        public static bool Data;
        public static bool onbatlle;
    }
    public class SaveDataClass
    {
        public Vector3 charpos;
        public Vector3[] othercharpos;
        public string[] othercharname;
        public Vector3 campos;
        public long hp;
        public long xp;
        public long level;
        public long[] ohp;
        public long[] oxp;
        public long[] olevel;
        public static SaveDataClass slot = new SaveDataClass();
        public static SaveDataClass fantomslot = new SaveDataClass();
        public static string Path(PlayerControler player)
        {
            return "save/" + player.character.namecharacter + "/scene-" + SceneManager.GetActiveScene().name;
        }
        public static string newPath(PlayerControler player,string newscene)
        {
            return "save/" + player.character.namecharacter + "/scene-" + newscene;
        }
        public static void save(PlayerControler player)
        {
            if (!isata.Data)
            {


                slot = new SaveDataClass();
                slot.campos = player._camera.transform.position;
                slot.charpos = player.character.transform.position;
                slot.hp = player.character.hp;
                slot.xp = player.character.xp;
                slot.level = player.character.level;
                slot.ohp = new long[player.othercharacters.Length];
                slot.oxp = new long[player.othercharacters.Length];
                slot.olevel = new long[player.othercharacters.Length];
                slot.othercharpos = new Vector3[player.othercharacters.Length];
                slot.othercharname = new string[player.othercharacters.Length];
                for (int i = 0; i < player.othercharacters.Length; i++)
                {
                    slot.ohp[i] = player.othercharacters[i].hp;
                    slot.oxp[i] = player.othercharacters[i].xp;
                    slot.olevel[i] = player.othercharacters[i].level;
                    slot.othercharpos[i] = player.othercharacters[i].transform.position;
                    slot.othercharname[i] = player.othercharacters[i].namecharacter;
                }
                Directory.CreateDirectory(Path(player));
                File.WriteAllText("save/data", SceneManager.GetActiveScene().name);
                File.WriteAllText(Path(player) + "/PlayerPosition.json", JsonUtility.ToJson(slot));
            }
        }
        public static void savemove(PlayerControler player,string loca)
        {

            if (!isata.Data)
            {

                
                slot = newload(player);
                fantomslot = newload1(player,loca);
                slot.campos = fantomslot.campos;
                slot.charpos = fantomslot.charpos;
                
                
                slot.othercharpos = new Vector3[slot.othercharpos.Length];
                for (int i = 0; i < player.othercharacters.Length; i++)
                {
                    
                    slot.othercharpos[i] = fantomslot.charpos;
                }
                Directory.CreateDirectory(newPath(player, loca));
                File.WriteAllText(newPath(player,loca) + "/PlayerPosition.json", JsonUtility.ToJson(slot));
            }
        }
        public static SaveDataClass newload(PlayerControler player)
        {
            SaveDataClass ss = new SaveDataClass();
            
            if (File.Exists(Path(player) + "/PlayerPosition.json"))
            {
                ss = JsonUtility.FromJson<SaveDataClass>(File.ReadAllText(Path(player) + "/PlayerPosition.json"));




                


            }
            return ss;
        }
        
        public static void load(PlayerControler player)
        {
            if (File.Exists(Path(player) + "/PlayerPosition.json"))
            {
                slot = JsonUtility.FromJson<SaveDataClass>(File.ReadAllText(Path(player) + "/PlayerPosition.json"));
                player.character.hp = slot.hp;
                player.character.xp = slot.xp;
                player.character.level = slot.level;
                player.character.transform.position = slot.charpos;
                player._camera.transform.position = slot.campos;


                for (int i = 0; i < slot.othercharname.Length; i++)
                {
                    player.create(slot.othercharname[i], slot.othercharpos[i], slot.ohp[i], slot.oxp[i], slot.olevel[i]);
                }




            }
        }
        public static SaveDataClass newload1(PlayerControler player ,string loka)
        {
            SaveDataClass ss = new SaveDataClass();
            
            if (File.Exists(newPath(player,loka) + "/PlayerPosition.json"))
            {
                ss = JsonUtility.FromJson<SaveDataClass>(File.ReadAllText(newPath(player, loka) + "/PlayerPosition.json"));




                


            }
            return ss;
        }
        public static void fall(PlayerControler player)
        {
           if( File.Exists(Path(player) + "/PlayerPosition.json"))
           {
                isata.Data = true;
                var isSignedIn = GameJolt.API.GameJoltAPI.Instance.CurrentUser != null;
                if (isSignedIn)
                {

                    GameJolt.API.Trophies.TryUnlock(173089);
                }
                File.Delete(Path(player) + "/PlayerPosition.json");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           }
        }
    }
}
