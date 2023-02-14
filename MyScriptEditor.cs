using UnityEditor;
using UnityEngine;

[CustomEditor (typeof(MyScript))]
public class MyScriptEditor : Editor
{
	// Variables
	private MyScript myScript;
    
	void OnEnable()
	{
		myScript = (MyScript)target;
	}
    
	public override void OnInspectorGUI()
	{
		// Increase/Decrease Mass
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Mass by 1"))
		{
			myScript.mass += 1;
		}
		if (GUILayout.Button("Decrease Mass by 1"))
		{
			myScript.mass -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Drag
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Drag by 1"))
		{
			myScript.drag += 1;
		}
		if (GUILayout.Button("Decrease Drag by 1"))
		{
			myScript.drag -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Angular Drag
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Angular Drag by 0.05"))
		{
			myScript.angularDrag += 0.05f;
		}
		if (GUILayout.Button("Decrease Angular Drag by 0.05"))
		{
			myScript.angularDrag -= 0.05f;
		}
		GUILayout.EndHorizontal();
        
		// Check Use Gravity
		myScript.useGravity = GUILayout.Toggle(myScript.useGravity, "Use Gravity");
        
		// Check Is Kinematic
		myScript.isKinematic = GUILayout.Toggle(myScript.isKinematic, "Is Kinematic");
        
		// Interpolate
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("None"))
		{
			myScript.interpolate = RigidbodyInterpolation.None;
		}
		if (GUILayout.Button("Extrapolate"))
		{
			myScript.interpolate = RigidbodyInterpolation.Extrapolate;
		}
		if (GUILayout.Button("Interpolate"))
		{
			myScript.interpolate = RigidbodyInterpolation.Interpolate;
		}
		GUILayout.EndHorizontal();
        
		// Collision Detection
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Discrete"))
		{
			myScript.collisionDetection = CollisionDetectionMode.Discrete;
		}
		if (GUILayout.Button("Continuous"))
		{
			myScript.collisionDetection = CollisionDetectionMode.Continuous;
		}
		if (GUILayout.Button("Continuous Dynamic"))
		{
			myScript.collisionDetection = CollisionDetectionMode.ContinuousDynamic;
		}
		if (GUILayout.Button("Continuous Speculative"))
		{
			myScript.collisionDetection = CollisionDetectionMode.ContinuousSpeculative;
		}
		GUILayout.EndHorizontal();
        
		// Check Constraints Freeze Position
		GUILayout.BeginHorizontal();
		myScript.constraintsFreezePositionX = GUILayout.Toggle(myScript.constraintsFreezePositionX, "Freeze Position X");
		myScript.constraintsFreezePositionY = GUILayout.Toggle(myScript.constraintsFreezePositionY, "Freeze Position Y");
		myScript.constraintsFreezePositionZ = GUILayout.Toggle(myScript.constraintsFreezePositionZ, "Freeze Position Z");
		GUILayout.EndHorizontal();
        
		// Check Constraints Freeze Rotation
		GUILayout.BeginHorizontal();
		myScript.constraintsFreezeRotationX = GUILayout.Toggle(myScript.constraintsFreezeRotationX, "Freeze Rotation X");
		myScript.constraintsFreezeRotationY = GUILayout.Toggle(myScript.constraintsFreezeRotationY, "Freeze Rotation Y");
		myScript.constraintsFreezeRotationZ = GUILayout.Toggle(myScript.constraintsFreezeRotationZ, "Freeze Rotation Z");
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Speed
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Speed by 1"))
		{
			myScript.speed += 1;
		}
		if (GUILayout.Button("Decrease Speed by 1"))
		{
			myScript.speed -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Velocity X
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Velocity X by 1"))
		{
			myScript.velocityX += 1;
		}
		if (GUILayout.Button("Decrease Velocity X by 1"))
		{
			myScript.velocityX -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Velocity Y
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Velocity Y by 1"))
		{
			myScript.velocityY += 1;
		}
		if (GUILayout.Button("Decrease Velocity Y by 1"))
		{
			myScript.velocityY -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Velocity Z
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Velocity Z by 1"))
		{
			myScript.velocityZ += 1;
		}
		if (GUILayout.Button("Decrease Velocity Z by 1"))
		{
			myScript.velocityZ -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Angular Velocity X
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Angular Velocity X by 1"))
		{
			myScript.angularVelocityX += 1;
		}
		if (GUILayout.Button("Decrease Angular Velocity X by 1"))
		{
			myScript.angularVelocityX -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Angular Velocity Y
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Angular Velocity Y by 1"))
		{
			myScript.angularVelocityY += 1;
		}
		if (GUILayout.Button("Decrease Angular Velocity Y by 1"))
		{
			myScript.angularVelocityY -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Angular Velocity Z
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Angular Velocity Z by 1"))
		{
			myScript.angularVelocityZ += 1;
		}
		if (GUILayout.Button("Decrease Angular Velocity Z by 1"))
		{
			myScript.angularVelocityZ -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Inertia Tensor X
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Inertia Tensor X by 1"))
		{
			myScript.inertiaTensorX += 1;
		}
		if (GUILayout.Button("Decrease Inertia Tensor X by 1"))
		{
			myScript.inertiaTensorX -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Inertia Tensor Y
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Inertia Tensor Y by 1"))
		{
			myScript.inertiaTensorY += 1;
		}
		if (GUILayout.Button("Decrease Inertia Tensor Y by 1"))
		{
			myScript.inertiaTensorY -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Inertia Tensor Z
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Inertia Tensor Z by 1"))
		{
			myScript.inertiaTensorZ += 1;
		}
		if (GUILayout.Button("Decrease Inertia Tensor Z by 1"))
		{
			myScript.inertiaTensorZ -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Inertia Tensor Rotation X
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Inertia Tensor Rotation X by 1"))
		{
			myScript.inertiaTensorRotationX += 1;
		}
		if (GUILayout.Button("Decrease Inertia Tensor Rotation X by 1"))
		{
			myScript.inertiaTensorRotationX -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Inertia Tensor Rotation Y
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Inertia Tensor Rotation Y by 1"))
		{
			myScript.inertiaTensorRotationY += 1;
		}
		if (GUILayout.Button("Decrease Inertia Tensor Rotation Y by 1"))
		{
			myScript.inertiaTensorRotationY -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Inertia Tensor Rotation Z
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Inertia Tensor Rotation Z by 1"))
		{
			myScript.inertiaTensorRotationZ += 1;
		}
		if (GUILayout.Button("Decrease Inertia Tensor Rotation Z by 1"))
		{
			myScript.inertiaTensorRotationZ -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Local Center of Mass X
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Local Center of Mass X by 1"))
		{
			myScript.localCenterOfMassX += 1;
		}
		if (GUILayout.Button("Decrease Local Center of Mass X by 1"))
		{
			myScript.localCenterOfMassX -= 1;
		}
		GUILayout.EndHorizontal();
        
		// Increase/Decrease Local Center of Mass Y
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase Local Center of Mass Y by 1"))
		{
			myScript.localCenterOfMassY += 1;
		}
		
		// Decrease local center of mass y
		if (GUILayout.Button("Decrease local center of mass y"))
		{
			myScript.DecreaseLocalCenterOfMassY();
		}
		GUILayout.EndHorizontal();

		// Increase local center of mass z
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase local center of mass z"))
		{
			myScript.IncreaseLocalCenterOfMassZ();
		}

		// Decrease local center of mass z
		if (GUILayout.Button("Decrease local center of mass z"))
		{
			myScript.DecreaseLocalCenterOfMassZ();
		}
		GUILayout.EndHorizontal();

		// Increase world center of mass x
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase world center of mass x"))
		{
			myScript.IncreaseWorldCenterOfMassX();
		}

		// Decrease world center of mass x
		if (GUILayout.Button("Decrease world center of mass x"))
		{
			myScript.DecreaseWorldCenterOfMassX();
		}
		GUILayout.EndHorizontal();

		// Increase world center of mass y
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase world center of mass y"))
		{
			myScript.IncreaseWorldCenterOfMassY();
		}

		// Decrease world center of mass y
		if (GUILayout.Button("Decrease world center of mass y"))
		{
			myScript.DecreaseWorldCenterOfMassY();
		}
		GUILayout.EndHorizontal();

		// Increase world center of mass z
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase world center of mass z"))
		{
			myScript.IncreaseWorldCenterOfMassZ();
		}

		// Decrease world center of mass z
		if (GUILayout.Button("Decrease world center of mass z"))
		{
			myScript.DecreaseWorldCenterOfMassZ();
		}
		GUILayout.EndHorizontal();

		// Start asleep
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("Start asleep"))
		{
			myScript.StartAsleep();
		}

		// Wake up
		if (GUILayout.Button("Wake up"))
		{
			myScript.WakeUp();
		}
		GUILayout.EndHorizontal();
	}
}
