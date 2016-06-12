//*************************************************************************
// Name: Rotator.cs
// Programmer: Curtis Frank
// Date: 5/15/2016
//*************************************************************************

using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
