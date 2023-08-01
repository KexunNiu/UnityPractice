using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xDeg = 0;
    [SerializeField] float yDeg = 1;
    [SerializeField] float zDeg = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xDeg,yDeg,zDeg);
    }
}
