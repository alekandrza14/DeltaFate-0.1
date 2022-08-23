using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class anim : MonoBehaviour
{
    public Image img;
    public string u;
    public float tic;
    public float time;
    public int scenestey; public bool scenestey2;
    public int katscene; public int katscenes;
    public float intensyty;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("epilog" + katscene, -1) == -1)
        {
            if ("epilog" + katscene != "epilog0")
            {


                PlayerPrefs.SetInt("epilog" + katscene, 0);
                SceneManager.LoadScene(katscene);

            }



        }
        if (PlayerPrefs.GetInt("epilogs" + katscenes, -1) == -1)
        {
            if ("epilogs" + katscenes != "epilogs0")
            {


                PlayerPrefs.SetInt("epilogs" + katscenes, 0);
                SceneManager.LoadScene(katscenes);

            }



        }
    }
    private void OnApplicationPause(bool pause)
    {
        PlayerPrefs.SetInt("epilogs" + katscenes, -1);

    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("epilogs" + katscenes, -1);
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt(u, -1) != -1)
        {
            tic += 1 * Time.fixedDeltaTime;
            if (tic <= 1)
            {

                img.color = new Color(intensyty, intensyty, intensyty, tic);


            }
            if (tic > 1)
            {


                SceneManager.LoadScene(PlayerPrefs.GetInt(u, -1));
                PlayerPrefs.SetInt(u, -1);

            }

        }
        if (scenestey2)
        {
            tic += 1 * Time.fixedDeltaTime;
            if (tic <= 1)
            {

                img.color = new Color(intensyty, intensyty, intensyty, tic);


            }
            if (tic > 1)
            {


                SceneManager.LoadScene(scenestey);


            }

        }
        

    }
}
