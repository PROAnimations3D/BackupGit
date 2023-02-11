using UnityEngine;
using System.Collections;

public class AngularDrag : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Get a wild spin under control when the user
    // presses the spacebar.
    void Update()
    {
        if (Input.GetKeyDown("space"))
            rb.angularDrag = 0.8F;
        else
            rb.angularDrag = 0;
    }
}
