using Unity.Entities;
using UnityEngine;

public class AppleAuthoring : MonoBehaviour
{
    public float bottomYposition = -20f;

    public class AppleBaker : Baker<AppleAuthoring>
    {
        public override void Bake(AppleAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            var appleComponent = new AppleProperties
            {
                BottomYPosition = authoring.bottomYposition
            };

            AddComponent(entity, appleComponent);
        }
    }
}


public struct AppleProperties : IComponentData
{
    public float BottomYPosition;
}

