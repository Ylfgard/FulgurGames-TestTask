using ResourceClicker.Resources;
using TMPro;
using UnityEngine;

namespace ResourceClicker
{
    //Базовый класс отвечающих за отображение объектов
    public abstract class View : MonoBehaviour
    {
        [SerializeField] protected TextMeshProUGUI _textTotal;

        protected IResourceClicker _presenter;
        protected IResourcesModel _model;

        public void Init(IResourceClicker presenter, IResourcesModel model)
        {
            _presenter = presenter;
            _model = model;
        }

        public abstract void DisplayResource(string resource, int count);

        public virtual void DisplayTotal(int totalResources)
        {
            _textTotal.text = totalResources.ToString();
        }
    }
}
