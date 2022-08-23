using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fightenter : MonoBehaviour
{
    public int idscene;
    public void pUpdate()
    {
        SceneManager.LoadScene(idscene);
    }
}
