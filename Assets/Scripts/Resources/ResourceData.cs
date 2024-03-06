using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

namespace ResourceClicker.Resources
{
    //Вспомогательный класс для прокидывания зависимостей
    [Serializable]
    public class ResourceData
    {
        [field: SerializeReference] public Button Button { get; private set; }
        [field: SerializeReference] public TextMeshProUGUI CountText { get; private set; }
        [field: SerializeReference] public TextMeshProUGUI ResourceText { get; private set; }

        public string Name => _resource.Name;

        [SerializeField] private Resource _resource;
    }
}