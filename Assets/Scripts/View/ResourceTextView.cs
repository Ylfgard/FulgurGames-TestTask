using ResourceClicker.Resources;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ResourceClicker
{
    //Отвечает за текстовое отображение ресурсов
    public class ResourceTextView : View
    {
        [SerializeField] protected ResourceData[] _resources;

        protected Dictionary<string, TextMeshProUGUI> _resourcesText;

        private void Start()
        {
            _resourcesText = new Dictionary<string, TextMeshProUGUI>();

            foreach (ResourceData resource in _resources)
            {
                resource.Button.onClick.AddListener(() =>
                        _presenter.OnResourceButtonClicked(resource.Name)
                    );
                _resourcesText.Add(resource.Name, resource.CountText);
                resource.ResourceText.text = resource.Name;
                resource.CountText.text = _model.Resources[resource.Name].ToString();
            }

            _textTotal.text = _model.TotalResources.ToString();
        }

        public override void DisplayResource(string resource, int count)
        {
            if (_resourcesText.TryGetValue(resource, out var text))
                text.text = count.ToString();
            else
                Debug.LogError("Wrong resource! " + resource);
        }
    }
}
