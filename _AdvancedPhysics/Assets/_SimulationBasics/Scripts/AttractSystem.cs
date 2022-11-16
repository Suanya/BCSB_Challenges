//using Unity.Entities;
//using Unity.Transforms;
//using Unity.Physics;
//using Unity.Mathematics;
using UnityEngine;

public class AttractSystem : MonoBehaviour // ComponentSystem
{ /*
    
    public float3 center;
    public float maxDistanceSqrd;
    public float strength;

    protected override unsafe void OnUpdate()
    {
        Entities.ForEach(
            (ref PhysicsVelocity velocity, ref Translation position, ref Rotation rotation) =>
            {
                float3 diff = center - ImagePosition.Value;
                float distSqrd = math.lengthsq(diff);

                if (distSqrd < maxDistanceSqrd)
                {
                    velocity.Linear += strength * (diff / math.sqrt(distSqrd));
                }
             });
    }
    */
};
