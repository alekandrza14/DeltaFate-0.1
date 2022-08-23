using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu_news : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (File.Exists(@"res/news.txt"))
        {
            txt.text = File.ReadAllText(@"res/news.txt");
        }
        if (Input.GetKey(deltacontrols.getcontrols.s12[3]))
        {
            s();
        }
    }
    public void s()
    {
        SceneManager.LoadScene(0);
    }
}
