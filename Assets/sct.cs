using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "scenes",menuName ="SceneMenager")]
public class sct : ScriptableObject
{
    public int[] idscene;
    public int[] idtype;
    [Header("0 spase")]
    [Header("1 home")]
    [Header("2 2D")]
    [Header("3 reyn")]
    [Header("4 2D reyn")]
    [Header("5 big reyn")]
    public bool yes;
}
