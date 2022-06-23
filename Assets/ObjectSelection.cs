using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    public enum Objects { Cube, Capsule}
    public Objects currentObj;
    

    public void CubeSelect()
    {
        currentObj = Objects.Cube;
    }
    public void CapsuleSelect()
    {
        currentObj = Objects.Capsule;
    }
}
