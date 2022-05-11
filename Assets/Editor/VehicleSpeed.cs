using System;
using UnityEditor;
using UnityEngine;

namespace BehaviorEditor
{ 
	[NodeEditor(typeof(VehicleSpeedNode))]
	[Category("PlayerVehicle")]
	public class VehicleSpeed : Node
	{

		protected override void OnNodeGUI()
		{
		base.OnNodeGUI();
		GUILayout.Label("<i>" + this.GetState().value + "</i>", Array.Empty<GUILayoutOption>());
		}


		private VehicleSpeedNode GetState()
		{
		return this.State as VehicleSpeedNode;
		}


		protected override void OnNodeInspectorGUI()
		{
		base.OnNodeInspectorGUI();
		EditorGUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUILayout.Label("Value:", Array.Empty<GUILayoutOption>());
		this.GetState().value = EditorGUILayout.FloatField(this.GetState().value, Array.Empty<GUILayoutOption>());
		EditorGUILayout.EndHorizontal();
		}
	}

}