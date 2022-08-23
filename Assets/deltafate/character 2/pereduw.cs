using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pereduw : MonoBehaviour
{
    public int idscene;
    public void exitsscene()
    {
        SceneManager.LoadScene(idscene);
;    }
}
