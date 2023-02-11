// Change the material depending on the speed of rotation
using UnityEngine;

public class AngularVelocity : MonoBehaviour
{
    public Material fastWheelMaterial;
    public Material slowWheelMaterial;
    public Rigidbody rb;
    public MeshRenderer rend;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (rb.angularVelocity.magnitude < 5)
            rend.sharedMaterial = slowWheelMaterial;
        else
            rend.sharedMaterial = fastWheelMaterial;
    }
}
