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
		EditorGUILayout.BeginHorizontal();
		if (GUILayout.Button("Increase by 1"))
		{
			script.SetMass(script.GetComponent<Rigidbody>().mass + 1f);
		}
		if (GUILayout.Button("Decrease by 1"))
		{
			script.SetMass(script.GetComponent<Rigidbody>().mass - 1f);
		}
		EditorGUILayout.EndHorizontal();

    }
}
