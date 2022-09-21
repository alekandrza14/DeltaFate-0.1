using System.Collections;
using System.Collections.Generic;
using System.Save;
using UnityEngine;
using UnityEngine.SceneManagement;

public class number
{
    public static int nb=-1;
}

public class portall : MonoBehaviour
{
    public int nb;
    public bool enter;
    public string loca;
    void Start()
    {
        if (number.nb == nb)
        {


            FindObjectOfType<PlayerControler>().character.transform.position = transform.position;
            number.nb = 0;
        }
    }


    void Update()
    {
        if (enter && DuoInput.Enter())
        {
            SaveDataClass.savemove(FindObjectOfType<PlayerControler>(), loca);
            SceneManager.LoadScene(loca);
            number.nb = nb;
            SaveDataClass.savemove(FindObjectOfType<PlayerControler>(), loca);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enter = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enter = !true;
        }
    }

}
