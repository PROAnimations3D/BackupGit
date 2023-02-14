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

    public void SetDrag(float value)
    {
        _rigidbody.drag = value;
    }

    public void SetAngularDrag(float value)
    {
        _rigidbody.angularDrag = value;
    }

    public void SetUseGravity(bool value)
    {
        _rigidbody.useGravity = value;
    }

    public void SetIsKinematic(bool value)
    {
        _rigidbody.isKinematic = value;
    }
}
