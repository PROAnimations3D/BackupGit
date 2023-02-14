using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MyScript : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void SetMass(float value)
    {
        _rigidbody.mass = value;
    }

}
