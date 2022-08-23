using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "data", menuName = "attack/1")]
public class ATTACK : ScriptableObject
{
    public int speedphase1;
    public int endphase1;
    public GameObject gameobjphase1;
    public int speedphase2;
    public int endphase2;
    public GameObject gameobjphase2;
    public int speedphase3;
    public int endphase3;
    public GameObject gameobjphase3;
}

