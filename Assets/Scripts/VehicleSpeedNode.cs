using System;
using JSon;
//using GameExtension;

public class VehicleSpeedNode : StateNode
{

    public override void Start()
    {
        Game.World.VehicleSpeed(this.value);
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

    public float value = 4f;
}