using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class transleators : MonoBehaviour
{
    public Text txt; public TextMesh txt2; public TextMeshProUGUI txt3;
    [Multiline(10)]
    public string[] lengich; public string[] lengich2;
    public bool alu; public bool spamton;
    // Start is called before the first frame update
    void Awake()
    {
        if (txt3)
        {
            txt3.text = lengich[PlayerPrefs.GetInt("ling", 0)];
            if (PlayerPrefs.GetInt("ling", 0) == 2)
            {


                txt3.font = Resources.Load<TMP_FontAsset>("front/arua");
            }
            if (PlayerPrefs.GetInt("ling", 0) != 2)
            {


                txt3.font = Resources.Load<TMP_FontAsset>("front/sis");
            }
            if (spamton)
            {


                txt3.font = Resources.Load<TMP_FontAsset>("front/det");
            }
        }
    }
    void Start()
    {
        if (txt)
            txt.text = lengich[PlayerPrefs.GetInt("ling", 0)];
        if (txt2)
            txt2.text = lengich[PlayerPrefs.GetInt("ling", 0)];
       
        if (txt && PlayerPrefs.GetInt("alu", 0) == 1 && alu)
            txt.text = lengich2[PlayerPrefs.GetInt("ling", 0)];
    }

    // Update is called once per frame
    void Update()
    {
        if (txt)
            txt.text = lengich[PlayerPrefs.GetInt("ling", 0)];
        if (txt2)
            txt2.text = lengich[PlayerPrefs.GetInt("ling", 0)];
        if (txt && PlayerPrefs.GetInt("alu",0) == 1 && alu)
            txt.text = lengich2[PlayerPrefs.GetInt("ling", 0)];
    }
}
