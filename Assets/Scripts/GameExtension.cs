using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JSon;
using System.Reflection;
using System.Runtime.CompilerServices;

#if UNITY_EDITOR
using UnityEditor;
#endif

public static class GameExtension
{
	public static void VehicleMaxFuel(this Game mf, float value)
	{
		if (Game.World && Game.World.Vehicle != null)
		{
			Game.World.Vehicle.maxFuel = value;
		}
	}
	public static void VehicleFuelConsumption(this Game fc, float value)
	{
		if (Game.World && Game.World.Vehicle != null)
		{
			Game.World.Vehicle.fuelConsumption = value;
		}
	}
}


 
	
