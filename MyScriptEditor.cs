using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MyScript))]
public class MyScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MyScript script = target as MyScript;

        EditorGUILayout.LabelField("Mass");
        if (GUILayout.Button("Increase by 1"))
        {
            script.SetMass(script.GetComponent<Rigidbody>().mass + 1f);
        }
        if (GUILayout.Button("Decrease by 1"))
        {
            script.SetMass(script.GetComponent<Rigidbody>().mass - 1f);
        }

        EditorGUILayout.LabelField("Drag");
        if (GUILayout.Button("Increase by 1"))
        {
            script.SetDrag(script.GetComponent<Rigidbody>().drag + 1f);
        }
        if (GUILayout.Button("Decrease by 1"))
        {
            script.SetDrag(script.GetComponent<Rigidbody>().drag - 1f);
        }

        EditorGUILayout.LabelField("Angular Drag");
        if (GUILayout.Button("Increase by 0.05"))
        {
            script.SetAngularDrag(script.GetComponent<Rigidbody>().angularDrag + 0.05f);
        }
        if (GUILayout.Button("Decrease by 0.05"))
        {
            script.SetAngularDrag(script.GetComponent<Rigidbody>().angularDrag - 0.05f);
        }

        EditorGUILayout.LabelField("Use Gravity");
        if (GUILayout.Button("True"))
        {
            script.SetUseGravity(true);
        }
        if (GUILayout.Button("False"))
        {
            script.SetUseGravity(false);
        }

        EditorGUILayout.LabelField("Is Kinematic");
        if (GUILayout.Button("True"))
        {
            script.SetIsKinematic(true);
        }
        if (GUILayout.Button("False"))
        {
            script.SetIsKinematic(false);
        }
    }
}
