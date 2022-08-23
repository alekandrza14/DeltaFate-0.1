using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_autor
{
    public string hp = "null";
    public string mp = "null";
    public string debug = "true";
    public string name;
    public void inicialize_autor()
    {
        name = "AlexandrUnauticna";
        Debug.LogWarning("имя "+name+" "+ "оз " + hp + " " + "рассудок " + mp + " " + "оладка " + debug);
    }
}
