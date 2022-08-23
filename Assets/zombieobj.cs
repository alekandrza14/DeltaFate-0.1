using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "data", menuName = "attack/2")]
public class zombieobj : ScriptableObject
{
    public GameObject[] idspawnzombie;
    public string[] namespawnzombie;
}