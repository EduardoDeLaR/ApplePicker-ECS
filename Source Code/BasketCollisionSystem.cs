using Unity.Burst;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Systems;

[UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
public partial struct BasketCollisionSystem : ISystem
{
    private SystemHandle<EndFixedStepSimulationEntityCommandBufferSystem> _commandBufferSystemHandle;

    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        _commandBufferSystemHandle = state.World.GetExistingSystem<EndFixedStepSimulationEntityCommandBufferSystem>();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        var commandBufferSystem = state.World.GetExistingSystem(_commandBufferSystemHandle);
        var commandBuffer = commandBufferSystem.CreateCommandBuffer().AsParallelWriter();

        Entities.ForEach((Entity entity, int entityInQueryIndex, in DynamicBuffer<PhysicsCollisionEvents> collisionEventsBuffer) =>
        {
            for (int i = 0; i < collisionEventsBuffer.Length; i++)
            {
                var collisionEvent = collisionEventsBuffer[i];
                var otherEntity = collisionEvent.EntityB;

                if (state.EntityManager.HasComponent<AppleComponent>(otherEntity))
                {
                    commandBuffer.DestroyEntity(entityInQueryIndex, otherEntity);
                }
            }

        }).ScheduleParallel();

        state.Dependency = commandBufferSystem.AddJobHandleForProducer(state.Dependency);
    }
}