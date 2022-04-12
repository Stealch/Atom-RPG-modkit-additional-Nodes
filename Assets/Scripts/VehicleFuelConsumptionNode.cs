using System;
using JSon;

public class VehicleFuelConsumptionNode : StateNode
{

    public override void Start()
    {
        Game.World.VehicleFuelConsumption(this.value);
    }


    public override void Serialize(JNode node)
    {
        node["value"] = new JData(this.value);
    }


    public override void Deserialize(JNode node)
    {
        bool flag = node["value"] != null;
        if (flag)
        {
            this.value = node["value"].AsFloat;
        }
    }

    public float value = 0.0125f;
}