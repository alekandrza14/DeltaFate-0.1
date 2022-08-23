using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controle_options : MonoBehaviour
{

    public InputField[] ifd;
    public string[] if2;

    private void Start()
    {
        for (int i = 0; i < ifd.Length; i++)
        {
            ifd[i].text = deltacontrols.getcontrols.s12[i];
        }
    }
    public void set()
    {
        for (int i = 0; i < ifd.Length;i++)
        {
            if2[i] = ifd[i].text;
        }
        deltacontrols.setcontrols s = new deltacontrols.setcontrols();

        s.Setkeycode(if2);
        SceneManager.LoadScene(0);
    }
}
