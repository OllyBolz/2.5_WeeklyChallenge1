using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 0.5f;
    private float rotationSpeed = 150f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        if (Mathf.Abs(verticalInput) > 0.5)
        {
            transform.Rotate(Vector3.left * verticalInput * rotationSpeed * Time.deltaTime);
        }
        else 
        {
            transform.Rotate(Vector3.zero);
        }
    }
}
