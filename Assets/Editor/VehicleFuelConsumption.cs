using System;
using UnityEditor;
using UnityEngine;

namespace BehaviorEditor
{ 
	[NodeEditor(typeof(VehicleFuelConsumptionNode))]
	[Category("PlayerVehicle")]
	public class VehicleFuelConsumption : Node
	{

		protected override void OnNodeGUI()
		{
		base.OnNodeGUI();
		GUILayout.Label("<i>" + this.GetState().value + "</i>", Array.Empty<GUILayoutOption>());
		}


		private VehicleFuelConsumptionNode GetState()
		{
		return this.State as VehicleFuelConsumptionNode;
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