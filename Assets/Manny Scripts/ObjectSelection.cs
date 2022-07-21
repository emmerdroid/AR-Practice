using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    public enum Objects { Cube, Capsule, None}
    public Objects currentObj;


    private void Start()
    {
        currentObj = Objects.None;
    }
    public void CubeSelect()
    {
        currentObj = Objects.Cube;
    }
    public void CapsuleSelect()
    {
        currentObj = Objects.Capsule;
    }
}
