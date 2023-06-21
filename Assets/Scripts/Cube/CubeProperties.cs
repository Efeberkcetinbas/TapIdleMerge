using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CubeProperties : MonoBehaviour
{
    public TextMeshPro[] NumberTexts;

    public int Number;

    public int staticId=0;

    internal int CubeID;

    internal bool IsMainCube;

    private void Awake() 
    {
        CubeID=staticId++;
    }


}
