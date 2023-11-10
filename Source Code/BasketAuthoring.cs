using Unity.Entities;
using UnityEngine;


public class BasketAuthoring : MonoBehaviour
{

    public float baseMoveSpeed = 1f;
    public Vector3 baseScale = new Vector3(1f, 1, 1);


    public class BasketBaker : Baker<BasketAuthoring>
    {
        public override void Bake(BasketAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new BasketComponent
            {
                MoveSpeed = authoring.baseMoveSpeed,
            });
        }
    }
}

// The IComponentData struct that will hold the ECS data for the basket.
public struct BasketComponent : IComponentData
{
    public float MoveSpeed;
}