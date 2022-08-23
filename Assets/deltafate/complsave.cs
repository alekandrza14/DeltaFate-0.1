using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class complsave : MonoBehaviour
{

    public rsave saveString1 = new rsave();
    public string name2;
    


    public string saveString221;

    
    public GameObject[] t3;


    



    
    public string[] info3;










    public void Start()
    {
        load();
    }
    private void Update()
    {

        save();



    }
    

    public void save()
    {
        
        saveString1.vector3A.Clear();
        saveString1.id.Clear();
        for (int i = 0; i < info3.Length; i++)
        {
            if (GameObject.FindGameObjectsWithTag(info3[i]).Length != 0)
            {


                for (int i3 = 0; i3 < GameObject.FindGameObjectsWithTag(info3[i]).Length; i3++)
                {

                    saveString1.id.Add(i);



                    saveString1.vector3A.Add(GameObject.FindGameObjectsWithTag(info3[i])[i3].transform.position);

                }
            }
            
        }
        
       


            
        
        



        Directory.CreateDirectory("DELTAFATE");
        Directory.CreateDirectory(@"DELTAFATE/" + name2.ToString());
        File.WriteAllText(@"DELTAFATE/"+name2.ToString() + @"/scene_" + SceneManager.GetActiveScene().name, JsonUtility.ToJson(saveString1));
        



    }
    public void load()
    {
        

        


        saveString221 = Path.Combine("DELTAFATE", name2 + @"/scene_" + SceneManager.GetActiveScene().name);



        if (File.Exists(saveString221))
        {
            saveString1 = JsonUtility.FromJson<rsave>(File.ReadAllText(saveString221));
            
            Debug.Log("IU");
        }
        else
        {
            Debug.Log("IU2");
            Directory.CreateDirectory("DELTAFATE");
            File.WriteAllText(@"DELTAFATE/" + name2 + @"/scene_" + SceneManager.GetActiveScene().name, JsonUtility.ToJson(saveString1));
            saveString1 = JsonUtility.FromJson<rsave>(File.ReadAllText(saveString221));
            
        }




        









            if (saveString1.vector3A.Count > 0)
            {


                for (int i3 = 0; i3 < saveString1.vector3A.Count; i3++)
                {




                    Debug.Log("1");
                    Instantiate(t3[saveString1.id[i3]].gameObject, new Vector3(saveString1.vector3A[i3].x, saveString1.vector3A[i3].y, saveString1.vector3A[i3].z), Quaternion.identity);



                }
            }

            
            








    }

   
}
[SerializeField]

public class rsave
{
    
    public List<Vector3> vector3A = new List<Vector3>();
    public List<int> id = new List<int>();
    
    




}


