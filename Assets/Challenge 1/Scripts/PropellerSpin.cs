using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float rotationSpeed = 300f;

    void Update()
    {
        transform.Rotate(new Vector3(0,0,1) * rotationSpeed * Time.deltaTime);
    }
}
