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
		bool flag = Game.World && Game.World.Vehicle != null;
		if (flag)
		{
			Game.World.Vehicle.maxFuel = value;
		}
	}
	public static void VehicleFuelConsumption(this Game fc, float value)
	{
		bool flag = Game.World && Game.World.Vehicle != null;
		if (flag)
		{
			Game.World.Vehicle.fuelConsumption = value;
		}
	}
	public static void VehicleSpeed(this Game sp, float value)
	{
		bool flag = Game.World && Game.World.Vehicle != null;
		if (flag)
		{
			Game.World.Vehicle.speed = value;
		}
	}
}


 
	
