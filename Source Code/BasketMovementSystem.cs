using Unity.Burst;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

[UpdateInGroup(typeof(SimulationSystemGroup))]
public partial struct BasketMovementSystem : ISystem
{
    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        foreach (var (transform, properties) in SystemAPI.Query<RefRW<LocalTransform>, RefRW<BasketComponent>>())
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.transform.position.z;
            var mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            float deltaTime = SystemAPI.Time.DeltaTime;

            properties.ValueRW.MoveSpeed = Mathf.Lerp(properties.ValueRW.MoveSpeed, mouseWorldPosition.x, properties.ValueRO.MoveSpeed * deltaTime);
        }
    }
}