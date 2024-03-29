﻿using UnityEngine;

namespace ResourceClicker.Resources
{
    //Scriptable Object для создания новых видов ресурсов
    [CreateAssetMenu (fileName = "NewResource", menuName = "Scriptable Objects/Resource")]
    public class Resource : ScriptableObject
    {
        [field: SerializeReference] public string Name { get; private set; }
        [field: SerializeReference] public float GeneratePeriod { get; private set; }
        [field: SerializeReference] public float ResourcesPerTick { get; private set; }
    }
}