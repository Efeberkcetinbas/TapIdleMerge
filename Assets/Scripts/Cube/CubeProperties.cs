using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CubeProperties : MonoBehaviour
{
    public TextMeshPro[] NumberTexts;

    public int Number;


    internal int CubeID;

    internal bool IsMainCube;

    public CubeData cubeData;

    private void Awake() 
    {
        cubeData.CubeId++;
        CubeID=cubeData.CubeId;
    }


}
