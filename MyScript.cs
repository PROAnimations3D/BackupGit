MyScript:

using UnityEngine;

public class MyScript : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void IncreaseMassByOne()
    {
        rb.mass += 1;
    }

    public void DecreaseMassByOne()
    {
        rb.mass -= 1;
    }

    public void IncreaseDragByOne()
    {
        rb.drag += 1;
    }

    public void DecreaseDragByOne()
    {
        rb.drag -= 1;
    }

    public void IncreaseAngularDragByPointFive()
    {
        rb.angularDrag += 0.05f;
    }

    public void DecreaseAngularDragByPointFive()
    {
        rb.angularDrag -= 0.05f;
    }

    public void SetUseGravity(bool value)
    {
        rb.useGravity = value;
    }

    public void SetIsKinematic(bool value)
    {
        rb.isKinematic = value;
    }

    public void SetInterpolate(RigidbodyInterpolation interpolation)
    {
        rb.interpolation = interpolation;
    }

    public void SetCollisionDetectionMode(CollisionDetectionMode collisionDetectionMode)
    {
        rb.collisionDetectionMode = collisionDetectionMode;
    }

    public void SetFreezePositionX(bool value)
    {
        rb.constraints = value ? rb.constraints | RigidbodyConstraints.FreezePositionX : rb.constraints & ~RigidbodyConstraints.FreezePositionX;
    }

    public void SetFreezePositionY(bool value)
    {
        rb.constraints = value ? rb.constraints | RigidbodyConstraints.FreezePositionY : rb.constraints & ~RigidbodyConstraints.FreezePositionY;
    }

    public void SetFreezePositionZ(bool value)
    {
        rb.constraints = value ? rb.constraints | RigidbodyConstraints.FreezePositionZ : rb.constraints & ~RigidbodyConstraints.FreezePositionZ;
    }

    public void SetFreezeRotationX(bool value)
    {
        rb.constraints = value ? rb.constraints | RigidbodyConstraints.FreezeRotationX : rb.constraints & ~RigidbodyConstraints.FreezeRotationX;
    }

    public void SetFreezeRotationY(bool value)
    {
        rb.constraints = value ? rb.constraints | RigidbodyConstraints.FreezeRotationY : rb.constraints & ~RigidbodyConstraints.FreezeRotationY;
    }

    public void SetFreezeRotationZ(bool value)
    {
        rb.constraints = value ? rb.constraints | RigidbodyConstraints.FreezeRotationZ : rb.constraints & ~RigidbodyConstraints.FreezeRotationZ;
    }

    public void IncreaseSpeedByOne()
    {
        rb.velocity += Vector3.one;
    }

    public void DecreaseSpeedByOne()
    {
        rb.velocity -= Vector3.one;
    }

    public void IncreaseVelocityXByOne()
    {
        rb.velocity += Vector3.right;
    }

    public void DecreaseVelocityXByOne()
    {
        rb.velocity -= Vector3.right;
    }

    public void IncreaseVelocityYByOne()
    {
        rb.velocity += Vector3.up;
    }

    public void DecreaseVelocityYByOne()
    {
        rb.velocity -= Vector3.up;
    }

    public void IncreaseVelocityZByOne()
    {
        rb.velocity += Vector3.forward;
    }

    public void DecreaseVelocityZByOne()
    {
        rb.velocity -= Vector3.forward;
    }

    public void IncreaseAngularVelocityXByOne()
    {
        rb.angularVelocity += Vector3.right;
    }

    public void DecreaseAngularVelocityXByOne()
    {
        rb.angularVelocity -= Vector3.right;
    }

    public void IncreaseAngularVelocityYByOne()
    {
        rb.angularVelocity += Vector3.up;
    }

    public void DecreaseAngularVelocityYByOne()
    {
        rb.angularVelocity -= Vector3.up;
    }

    public void IncreaseAngularVelocityZByOne()
    {
        rb.angularVelocity += Vector3.forward;
    }

    public void DecreaseAngularVelocityZByOne()
    {
        rb.angularVelocity -= Vector3.forward;
    }

    public void IncreaseInertiaTensorXByOne()
    {
        rb.inertiaTensor += Vector3.right;
    }

    public void DecreaseInertiaTensorXByOne()
    {
        rb.inertiaTensor -= Vector3.right;
    }

    public void IncreaseInertiaTensorYByOne()
    {
        rb.inertiaTensor += Vector3.up;
    }

    public void DecreaseInertiaTensorYByOne()
    {
        rb.inertiaTensor -= Vector3.up;
    }

    public void IncreaseInertiaTensorZByOne()
    {
        rb.inertiaTensor += Vector3.forward;
    }

    public void DecreaseInertiaTensorZByOne()
    {
        rb.inertiaTensor -= Vector3.forward;
    }

    public void IncreaseInertiaTensorRotationXByOne()
    {
        rb.inertiaTensorRotation += Vector3.right;
    }

    public void DecreaseInertiaTensorRotationXByOne()
    {
        rb.inertiaTensorRotation -= Vector3.right;
    }

    public void IncreaseInertiaTensorRotationYByOne()
    {
        rb.inertiaTensorRotation += Vector3.up;
    }

    public void DecreaseInertiaTensorRotationYByOne()
    {
        rb.inertiaTensorRotation -= Vector3.up;
    }

    public void IncreaseInertiaTensorRotationZByOne()
    {
        rb.inertiaTensorRotation += Vector3.forward;
    }

    public void DecreaseInertiaTensorRotationZByOne()
    {
        rb.inertiaTensorRotation -= Vector3.forward;
    }

    public void IncreaseLocalCenterOfMassXByOne()
    {
        rb.centerOfMass += Vector3.right;
    }

    public void DecreaseLocalCenterOfMassXByOne()
    {
        rb.centerOfMass -= Vector3.right;
    }

    public void IncreaseLocalCenterOfMassYByOne()
    {
        rb.centerOfMass += Vector3.up;
    }

    public void DecreaseLocalCenterOfMassYByOne()
    {
        rb.centerOfMass -= Vector3.up;
    }

    public void IncreaseLocalCenterOfMassZByOne()
    {
        rb.centerOfMass += Vector3.forward;
    }

    public void DecreaseLocalCenterOfMassZByOne()
    {
        rb.centerOfMass -= Vector3.forward;
    }

    public void IncreaseWorldCenterOfMassXByOne()
    {
        rb.worldCenterOfMass += Vector3.right;
    }

    public void DecreaseWorldCenterOfMassXByOne()
    {
        rb.worldCenterOfMass -= Vector3.right;
    }

    public void IncreaseWorldCenterOfMassYByOne()
    {
        rb.worldCenterOfMass += Vector3.up;
    }

    public void DecreaseWorldCenterOfMassYByOne()
    {
        rb.worldCenterOfMass -= Vector3.up;
    }

    public void IncreaseWorldCenterOfMassZByOne()
    {
        rb.worldCenterOfMass += Vector3.forward;
    }

    public void DecreaseWorldCenterOfMassZByOne()
    {
        rb.worldCenterOfMass -= Vector3.forward;
    }

    public void SetSleepState(RigidbodySleepMode sleepMode)
    {
        rb.sleepMode = sleepMode;
    }
}
